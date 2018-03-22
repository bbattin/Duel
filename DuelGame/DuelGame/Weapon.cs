using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Weapon
    {
        public int Light { get; set ; }
        public int Shield { get ; set ; }

        abstract protected int GetTotalShield();

        private int _light;   // легкость
        private int _shield;  // защита
    }
}
