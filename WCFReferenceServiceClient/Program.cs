using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFReferenceServiceClient.WCFRef;

namespace WCFReferenceServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new PLCDataServiceContractClient("TCPEndpoint");

            PLCDataPacketConfiguration newPacketConfig = new PLCDataPacketConfiguration();

            //1a. specify if this configuration is a decoder or encoder:
            newPacketConfig.IsDecoder = true;

            List<DataByte> byteList = new List<DataByte>();

            //1b. start adding to the list of Bytes in this packet (start with header):
            DataByte dbyteHeader = new DataByte();
            dbyteHeader.IsHeaderOrFooter = true;
            dbyteHeader.ByteIndex = 0;
            byteList.Add(dbyteHeader);

            //2. add Byte with indicator that it contains Bit "flags":
            DataByte dbyte1 = new DataByte();
            dbyte1.ContainsBits = true;
            dbyte1.ByteIndex = 1;

            //3. iterate thru UI controls (refactor DataBit array items from UI control values), and populate Bits:
            List<DataBit> bitList = new List<DataBit>();
            bitList.Add(new DataBit { AGVTags = new int[105], BitIndex = 0, Description = "HVAC Lineside" });

            //not able to do this in a foreach related to UI control (array length is indeterminate):
            DataBit[] dBitArray = { 
                                      new DataBit { AGVTags = new int[135], BitIndex = 1, Description = "HVAC Pickside"},
                                      new DataBit { AGVTags = new int[205], BitIndex = 2, Description = "Wires Lineside" },
                                      new DataBit { AGVTags = new int[220], BitIndex = 3, Description = "Wires Pickside" },
                                      new DataBit { AGVTags = new int[220], BitIndex = 4, Description = "Steering Lineside" },
                                      new DataBit { AGVTags = new int[305], BitIndex = 5, Description = "Steering Pickside" },
                                      new DataBit { AGVTags = new int[330], BitIndex = 6, Description = "Steering Staging" },
                                  };
            bitList.AddRange(dBitArray); 
            
            //4. add to DataByte's DataBit array:
            dbyte1.Bits = bitList.ToArray();
            byteList.Add(dbyte1);
            
            //5. add a footer (remaining Bytes not specified will be backfilled or ignored when decoding/encoding)
            DataByte dbyteFooter = new DataByte();
            dbyteFooter.IsHeaderOrFooter = true;
            dbyteFooter.ByteIndex = 11;
            byteList.Add(dbyteFooter);

            newPacketConfig.Bytes = byteList.ToArray(); //new DataByte[] {dbyteHeader, dbyte1, dbyteFooter}; //again, this is not iterator friendly

            Console.WriteLine("Enter the name of the configuration you would like to store/retrieve:");
            string configName = Console.ReadLine();
            Console.WriteLine(@"WCF proxy method StorePLCDataPacketConfiguration() returned: {0} (true = successful storage of PLCDataPacket configuration)",
                proxy.StorePLCDataPacketConfiguration(newPacketConfig, configName));

            Console.WriteLine("-------------------------------------------------------------");
            PLCDataPacketConfiguration configFromFileIO = proxy.GetPLCDataPacketConfiguration(configName);
            Console.WriteLine(@"WCF proxy method GetPLCDataPacketConfiguration() for returned object: {0} for PLCDataPacket configuration named: {1} contains:",
                configFromFileIO, configName);

            foreach (DataByte b in configFromFileIO.Bytes)
            {
                Console.WriteLine("DataByte index:  {0} | IsHeaderOrFooter: {1} | ContainsBitFlags: {2}", b.ByteIndex, b.IsHeaderOrFooter, b.ContainsBits);
            }

            proxy.Close();

            Console.WriteLine("Press <ENTER> to exit...");
            Console.Read();
        }
    }
}
