using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Hunting.Serialization
{
    [DataContract]
    public class Event
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime Date { get; set; }
    }
}
