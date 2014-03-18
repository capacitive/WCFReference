using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFReferenceService
{
    public class WCFService : IServiceContract
    {
        public void StorePLCDataPacketConfiguration(PLCDataPacketConfiguration PLCPacket, string configurationName)
        {
            
        }

        public PLCDataPacketConfiguration GetPLCDataPacketConfiguration(string configurationName)
        {
            throw new NotImplementedException();
        }
    }
}
