using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Equipment : IEquipment
    {
        public int Damage { get ; set ; }
        public int Aiming { get ; set ; }
        public int Light { get ; set ; }
        public int CountUsing { get ; set ; }
        public int Shield { get ; set ; }
    }
}
