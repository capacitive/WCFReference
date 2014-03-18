using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFReferenceService
{
    [DataContract]
    public class PLCDataPacketConfigurationSet
    {
        [DataMember]
        public Dictionary<string, PLCDataPacketConfiguration> PLCDataPacketConfigurations { get; set; }
    }

    [DataContract]
    public class PLCDataPacketConfiguration
    {
        [DataMember]
        public List<DataByte> Bytes { get; set; }
    }

    [DataContract]
    public class DataByte
    {
        [DataMember]
        public bool IsHeaderOrFooter { get; set; }
        [DataMember]
        public int ByteIndex { get; set; }
        [DataMember]
        public List<DataBit> Bits { get; set; }
    }

    [DataContract]
    public class DataBit
    {

        public List<int> AGVTags { get; set; }
        public int BitIndex { get; set; }
        public string Description { get; set; }
    }
}
