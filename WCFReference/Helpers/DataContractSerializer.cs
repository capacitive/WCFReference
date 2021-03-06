﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WCFReferenceService.Helpers
{
    public class DataContractSerializer<T> : XmlObjectSerializer
    {
        DataContractSerializer _dataContractSerializer;

        public DataContractSerializer()
        {
            _dataContractSerializer = new DataContractSerializer(typeof(T));
        }

        public new T ReadObject(Stream stream)
        {
            return (T)_dataContractSerializer.ReadObject(stream);
        }

        public new T ReadObject(XmlReader reader)
        {
            return (T)_dataContractSerializer.ReadObject(reader);
        }

        public void WriteObject(Stream stream, T graph)
        {
            _dataContractSerializer.WriteObject(stream, graph);
        }

        public void WriteObject(XmlWriter writer, T graph)
        {
            _dataContractSerializer.WriteObject(writer, graph);
        }

        public override bool IsStartObject(XmlDictionaryReader reader)
        {
            throw new NotImplementedException();
        }

        public override object ReadObject(XmlDictionaryReader reader, bool verifyObjectName)
        {
            throw new NotImplementedException();
        }

        public override void WriteEndObject(XmlDictionaryWriter writer)
        {
            throw new NotImplementedException();
        }

        public override void WriteObjectContent(XmlDictionaryWriter writer, object graph)
        {
            throw new NotImplementedException();
        }

        public override void WriteStartObject(XmlDictionaryWriter writer, object graph)
        {
            throw new NotImplementedException();
        }
    }
}
