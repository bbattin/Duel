using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Armor
    {
        public int Damage { get; set; }
        public int Aiming { get; set; }
        public int CountUsing { get; set; }

        abstract protected int GetTotalDamage();

        private int _damage;       // урон
        private int _aiming;       // прицельность
        private int _countUsing;   // количество использований (патроны, стрелы)
    }
}
 