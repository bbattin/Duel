using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Personage : ICharacteristic
    {
        
        protected int money = 5;         // деньги на покупку оружия/брони

        List<Equipment> equipment;      // снаряжение

        public abstract int live { get; set; }
        public abstract int force { get; set; }
        public abstract int protection { get; set; }
        public abstract int adroitness { get; set; }
        public abstract int accuracy { get; set; }
        public abstract int educability { get; set; }
    }
}
