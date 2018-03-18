using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Personage : ICharacteristic
    {
        
        public int Live { get; set; }
        public int Force { get; set; }
        public int Protection { get; set; }
        public int Adroitness { get; set; }
        public int Accuracy { get; set; }
        public int Educability { get; set; }
        public string Name { get => _name; set => _name = value; }

        protected string _name;

        //protected abstract void ToAttack();
        //protected abstract void ToProtection();
        //protected abstract void UseFeatures();

        //protected int money = 5;         // деньги на покупку оружия/брони
        //protected int level = 1;         // уровень
        //List<Equipment> equipment;       // снаряжение
    }
}
