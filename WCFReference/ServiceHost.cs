using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFReferenceService
{
    public class ServiceHost<T> : ServiceHost
    {
        public ServiceHost() : base(typeof(T))
        {}

        public ServiceHost(params string[] baseAddresses) : base(typeof(T), baseAddresses.Select(address => new Uri(address)).ToArray())
        {}

        public ServiceHost(params Uri[] baseAddresses) : base(typeof(T), baseAddresses)
        {}
    }
}
