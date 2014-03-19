using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFReferenceService
{
    [DataContract]
    [Serializable]
    public class PLCDataPacketConfiguration
    {
        [DataMember]
        public List<DataByte> Bytes { get; set; }
        [DataMember]
        public bool IsDecoder { get; set; }
    }

    [DataContract]
    [Serializable]
    public class DataByte
    {
        [DataMember]
        public bool IsHeaderOrFooter { get; set; }
        [DataMember]
        public bool ContainsBits { get; set; }
        [DataMember]
        public int ByteIndex { get; set; }
        [DataMember]
        public List<DataBit> Bits { get; set; }
    }

    [DataContract]
    [Serializable]
    public class DataBit
    {
        [DataMember]
        public List<int> AGVTags { get; set; }
        [DataMember]
        public int BitIndex { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
