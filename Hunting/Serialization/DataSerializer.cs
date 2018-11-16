using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Hunting.Serialization
{
    public class DataSerializer
    {
        public static void SerializeData(string fileName, DataModel data)
        {
            //var formatter = new BinaryFormatter();
            if(fileName.Length > 1)
                File.Delete(fileName);
            var formatter = new DataContractSerializer(typeof(DataModel));
            var s = new FileStream(fileName, FileMode.Create);
            //formatter.Serialize(s, data);
            formatter.WriteObject(s, data);
            s.Close();
        }
        public static DataModel DeserializeItem(string fileName)
        {
            var s = new FileStream(fileName, FileMode.Open);
            // var formatter = new BinaryFormatter();
            var formatter = new DataContractSerializer(typeof(DataModel));
            //return (DataModel)formatter.Deserialize(s);
            return (DataModel)formatter.ReadObject(s);
        }
    }
}
