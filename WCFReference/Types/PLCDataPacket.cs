using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFReferenceService
{
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
        public bool ContainsBits { get; set; }
        [DataMember]
        public int ByteIndex { get; set; }
        [DataMember]
        public List<DataBit> Bits { get; set; }
    }

    [DataContract]
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
