using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFReferenceService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceContract" in both code and config file together.
    [ServiceContract]
    public interface IServiceContract
    {
        [OperationContract]
        void StorePLCDataPacketConfiguration(PLCDataPacketConfiguration PLCPacket, string configurationName);

        [OperationContract]
        PLCDataPacketConfiguration GetPLCDataPacketConfiguration(string configurationName);
    }
}
