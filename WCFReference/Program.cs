using SimpleServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WCFReferenceService
{
    [RunInstaller(true)]
    public class Program : SimpleServiceApplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Windows Services container context:");

            new Service(args,
                        new List<IWindowsService> { 
                            new WCFServiceHost()
                        }.ToArray, installationSettings: (serviceInstaller, serviceProcessInstaller) =>
                        {
                            serviceInstaller.ServiceName = "WCFReference_HostService";
                            serviceInstaller.StartType = ServiceStartMode.Manual;
                            serviceProcessInstaller.Account = ServiceAccount.LocalSystem;
                        },
                        configureContext: x =>
                        {
                            x.Log = Console.WriteLine;
                        })
                .Host();

            Console.WriteLine("Press <ENTER> to close this window.");
            Console.ReadLine();
        }
    }
}
