using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Armor
    {
        public int Damage { get => _damage; set => _damage = value; }
        public int Aiming { get => _aiming; set => _aiming = value; }
        public int CountUsing { get => _countUsing; set => _countUsing = value; }

        abstract protected int GetTotalDamage();

        private int _damage;       // урон
        private int _aiming;       // прицельность
        private int _countUsing;   // количество использований (патроны, стрелы)
    }
}
 