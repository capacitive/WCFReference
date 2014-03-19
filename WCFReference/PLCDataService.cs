using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.Text;

namespace WCFReferenceService
{
    public class PLCDataService : IPLCDataServiceContract
    {
        public void StorePLCDataPacketConfiguration(PLCDataPacketConfiguration PLCPacket, string configurationName)
        {
            string filePath = String.Format("{0}/{1}.bin", Assembly.GetExecutingAssembly().Location, configurationName);

            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(configurationName + ".bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, PLCPacket);
            stream.Close();
        }

        public PLCDataPacketConfiguration GetPLCDataPacketConfiguration(string configurationName)
        {
            string filePath = String.Format("{0}/{1}.bin", Assembly.GetExecutingAssembly().Location, configurationName);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            PLCDataPacketConfiguration packet = (PLCDataPacketConfiguration)formatter.Deserialize(stream);
            stream.Close();

            return packet;
        }
    }
}
