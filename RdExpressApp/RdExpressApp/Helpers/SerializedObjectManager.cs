using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace RdExpressApp.Helpers
{
    public class SerializedObjectManager
    {
        string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BranchId");

        public void SaveData(object serializedData)
        {
            var save = serializedData;

            var binaryFormatter = new BinaryFormatter();
            using (var fileStream = File.Create(savePath))
            {
                binaryFormatter.Serialize(fileStream, save);
            }
        }
        public object RetrieveData()
        {
            object load = null;

            if (File.Exists(savePath))
            {
                var binaryFormatter = new BinaryFormatter();
                using (var fileStream = File.Open(savePath, FileMode.Open))
                {
                    load = (object)binaryFormatter.Deserialize(fileStream);

                    return load;
                }
            }

            return null;
        }
    }
}
