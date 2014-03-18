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
            ServiceContractClient proxy = new ServiceContractClient("TCPEndpoint");
            Console.WriteLine(@"WCF proxy returned: [{0}]", "filler");
            proxy.Close();

            Console.WriteLine("Press <ENTER> to exit...");
            Console.Read();
        }
    }
}
