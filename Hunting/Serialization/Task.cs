using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Hunting.Serialization
{
    [DataContract]
    public class Task
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Weapon { get; set; }

        [DataMember]
        public string Location { get; set; }

    }
}
