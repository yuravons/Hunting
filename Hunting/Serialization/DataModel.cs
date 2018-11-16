using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Hunting.Serialization
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Task> Tasks { get; set; }

        [DataMember]
        public IEnumerable<Project> Projects { get; set; }

        [DataMember]
        public IEnumerable<Event> Events { get; set; }

        public DataModel()
        {
            Tasks = new List<Task>() { new Task() { Login = "Yura", Weapon = "Glock", Location = "Western"} };
            Projects = new List<Project>() { new Project() };
            Events = new List<Event>() { new Event() };
        }

        public static string DataPath = "Hunting.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);
            }
            return new DataModel();
        }
        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }
    }
}
