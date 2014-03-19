using SimpleServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFReferenceService
{
    public class WCFServiceHost : IWindowsService
    {
        ServiceHost host1 = new ServiceHost(typeof(PLCDataService));
        //ServiceHost host2 = new ServiceHost(typeof(WCFService));

        public ApplicationContext AppContext { get; set; } 

        public void Start(string[] args)
        {
            //host1.CloseTimeout = TimeSpan.FromSeconds(20); //set in config file
            host1.Faulted += host1_Faulted;
            host1.Open();

            //programmatic base address:
            //Uri host2BaseAddress = new Uri("http://localhost:8888/");
            //host2 = new ServiceHost(typeof(WCFService), host2BaseAddress);
            //host2.Open();
        }

        void host1_Faulted(object sender, EventArgs e)
        {
            Console.WriteLine("Service host @ {0} faulted.", host1.BaseAddresses[0]);
        }

        public void Stop()
        {        
            host1.Close();
            //host2.Close();
            Console.WriteLine("ServiceHost closed.");
        }
    }
}
