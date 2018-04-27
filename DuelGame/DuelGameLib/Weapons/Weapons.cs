using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace DuelGame
{
    [DataContract]
    class Weapons
        // оружие
    {
        [DataMember]
        public string Name { get; protected set; }       // название
        [DataMember]
        public int Damage { get; protected set; }        // урон
        [DataMember]
        public int Protection { get; protected set; }    // защита

       
    }
}
