using System;
using System.Collections.Generic;
using System.Linq;
using WCFReferenceServiceClient.WCFRef;

namespace WCFReferenceServiceClient
{
    class Program
    {
        static PLCDataPacketConfiguration _newPacketConfig = new PLCDataPacketConfiguration();

        static void Main(string[] args)
        {
            var proxy = new PLCDataServiceContractClient("TCPEndpoint");

            //1a. specify if this configuration is a decoder or encoder:
            _newPacketConfig.IsDecoder = true;

            List<DataByte> byteList = new List<DataByte>();

            //1b. start adding to the list of Bytes in this packet (start with header - entered by user in case of working with headerless packet)
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
            
            //5. add a footer (remaining Bytes not specified will be backfilled or ignored when decoding/encoding - will need to be entered by user)
            DataByte dbyteFooter = new DataByte();
            dbyteFooter.IsHeaderOrFooter = true;
            dbyteFooter.ByteIndex = 11;
            byteList.Add(dbyteFooter);

            _newPacketConfig.Bytes = byteList.ToArray(); //new DataByte[] {dbyteHeader, dbyte1, dbyteFooter}; //again, this is not iterator friendly

            Console.WriteLine("Enter the name of the configuration you would like to store/retrieve:");
            string configName = Console.ReadLine();
            Console.WriteLine(@"WCF method StorePLCDataPacketConfiguration() returned: {0} (true = successful storage of PLCDataPacket configuration)",
                proxy.StorePLCDataPacketConfiguration(_newPacketConfig, configName));

            Console.WriteLine("-------------------------------------------------------------");

            PLCDataPacketConfiguration configFromBinary = proxy.GetPLCDataPacketConfiguration(configName);
            Console.WriteLine(@"WCF method GetPLCDataPacketConfiguration() returned PLCDataPacket configuration named: {1} which contains:",
                configFromBinary, configName);

            foreach (DataByte b in configFromBinary.Bytes)
            {
                Console.WriteLine("DataByte index:  {0} | IsHeaderOrFooter: {1} | ContainsBitFlags: {2}", b.ByteIndex, b.IsHeaderOrFooter, b.ContainsBits);
                if (b.ContainsBits)
                {
                    foreach(DataBit db in b.Bits)
                    {
                        Console.WriteLine("DataBit index: {0} | description: {1}", db.BitIndex, db.Description);
                    }
                }
            }

            proxy.Close();

            Console.WriteLine("Press <ENTER> to exit...");
            Console.Read();
        }

        public bool AddHeader(ref PLCDataPacketConfiguration config)
        {
            try
            {
                DataByte header = new DataByte();
                header.IsHeaderOrFooter = true;
                header.ByteIndex = 0;
                config.Bytes.SetValue(header, 0);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool AddByteWithBitFlags(PLCDataPacketConfiguration config, List<DataBit> dataBits)
        {
            try
            {
                List<DataByte> byteList = new List<DataByte>();
                byteList.AddRange(config.Bytes);
                int lastIndex = byteList.FindLastIndex(FindDataByte);

                DataByte byteWithBits = new DataByte();
                byteWithBits.ContainsBits = true;
                byteWithBits.ByteIndex = lastIndex + 1;
                
                foreach (DataBit dBit in dataBits)
                {
                    byteWithBits.Bits.SetValue(dBit, dBit.BitIndex);                                        
                }

                config.Bytes.SetValue(byteWithBits, lastIndex + 1);
            }
            catch
            {

                return false;
            }
            return true;
        }

        public bool AddFooter(int byteIndex, ref PLCDataPacketConfiguration config)
        {
            List<DataByte> byteList = new List<DataByte>();
            byteList.AddRange(config.Bytes);
            int lastIndex = byteList.FindLastIndex(FindDataByte);
            if (lastIndex > -1)
            {
                DataByte footer = new DataByte();
                footer.IsHeaderOrFooter = true;
                footer.ByteIndex = byteIndex;

                //add the remaining Bytes required as placeholders (desired ByteIndex - current ByteIndex = remaining Byte "slots" required):
                int placeholderCount = byteIndex - lastIndex;
                for (int i = lastIndex + 1; i <= placeholderCount; i++)
                {
                    DataByte placeHolder = new DataByte();
                    placeHolder.ByteIndex = i;
                    config.Bytes.SetValue(placeHolder, i);
                }

                config.Bytes.SetValue(footer, byteIndex);
            }
            else
            {
                return false;
            }
            return true;
        }

        private static bool FindDataByte(DataByte dByte)
        {
            if (dByte.ByteIndex > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
