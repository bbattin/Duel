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

        public int live { get; set; }
        public int force { get; set; }
        public int protection { get; set; }
        public int adroitness { get; set; }
        public int accuracy { get; set; }
        public int educability { get; set; }

        protected abstract void ToAttack();
        protected abstract void ToProtection();
        protected abstract void UseFeatures();
    }
}
