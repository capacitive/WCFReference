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
        public bool StorePLCDataPacketConfiguration(PLCDataPacketConfiguration PLCPacket, string configurationName)
        {
            try
            {
                string filePath = CreateFilePath(configurationName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, PLCPacket);
                stream.Close();
            }
            catch {
                return false;
            }

            return true;
        }

        public PLCDataPacketConfiguration GetPLCDataPacketConfiguration(string configurationName)
        {
            string filePath = CreateFilePath(configurationName);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            PLCDataPacketConfiguration packet = (PLCDataPacketConfiguration)formatter.Deserialize(stream);
            stream.Close();

            return packet;
        }

        private string CreateFilePath(string fileName)
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            int endIndex = assemblyLocation.LastIndexOf(@"\");

            string filePath = String.Format("{0}\\{1}.bin", assemblyLocation.Substring(0, endIndex), fileName);
            return filePath;
        }
    }
}
