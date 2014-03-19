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
            DataByte dbyteHeader = new DataByte();
            dbyteHeader.IsHeaderOrFooter = true;
            dbyteHeader.ByteIndex = 0;

            DataByte dbyte1 = new DataByte();
            dbyte1.ContainsBits = true;
            dbyte1.ByteIndex = 1;

            DataBit[] dBitArray = { 
                                      new DataBit { AGVTags = new int[105], BitIndex = 0, Description = "HVAC Lineside" },
                                      new DataBit { AGVTags = new int[135], BitIndex = 1, Description = "HVAC Pickside"}
                                  };
            
            DataByte dbyteFooter = new DataByte();
            dbyteFooter.IsHeaderOrFooter = true;
            dbyteFooter.ByteIndex = 11;

            //proxy.StorePLCDataPacketConfiguration(

            Console.WriteLine(@"WCF proxy returned: [{0}]", "filler");
            proxy.Close();

            Console.WriteLine("Press <ENTER> to exit...");
            Console.Read();
        }
    }
}
