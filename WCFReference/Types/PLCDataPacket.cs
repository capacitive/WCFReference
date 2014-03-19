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
        List<DataByte> _byteList = new List<DataByte>();

        [DataMember]
        public List<DataByte> Bytes 
        { 
            get { return _byteList; } 
            set { _byteList = value; }
        }      

        [DataMember]
        public bool IsDecoder { get; set; }

        //public bool AddHeader()
        //{
        //    try
        //    {
        //        DataByte header = new DataByte();
        //        header.IsHeaderOrFooter = true;
        //        header.ByteIndex = 0;
        //        _byteList.Add(header);
        //    }
        //    catch
        //    {
        //        return false; 
        //    }
        //    return true;
        //}

        //public bool AddByteWithBitFlags()
        //{
        //    try
        //    {
        //        int lastIndex = Bytes.FindLastIndex(FindDataByte);

        //        DataByte byteWithBits = new DataByte();
        //        byteWithBits.ContainsBits = true;
        //        byteWithBits.ByteIndex = lastIndex + 1;

        //        _byteList.Add(byteWithBits);
        //    }
        //    catch
        //    {
                
        //        return false;
        //    }
        //    return true;
        //}

        //public bool AddFooter(int byteIndex)
        //{
        //    int lastIndex = Bytes.FindLastIndex(FindDataByte);
        //    if (lastIndex > -1)
        //    {
        //        DataByte footer = new DataByte();
        //        footer.IsHeaderOrFooter = true;
        //        footer.ByteIndex = byteIndex;

        //        //add the remaining Bytes required as placeholders (desired ByteIndex - current ByteIndex = remaining Byte "slots" required):
        //        int placeholderCount = byteIndex - lastIndex;
        //        for (int i = lastIndex + 1; i <= placeholderCount; i++)
        //        {
        //            DataByte placeHolder = new DataByte();
        //            placeHolder.ByteIndex = i;
        //            _byteList.Add(placeHolder);
        //        }

        //        _byteList.Add(footer);
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //private static bool FindDataByte(DataByte dByte)
        //{
        //    if (dByte.ByteIndex > 0)
        //    {
        //        return true;
        //    }
        //    else 
        //    {
        //        return false;
        //    }
        //}
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
