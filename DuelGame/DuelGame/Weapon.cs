using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Weapon
    {
        public int Light { get => _light; set => _light = value; }
        public int Shield { get => _shield; set => _shield = value; }

        abstract protected int GetTotalShield();

        private int _light;   // легкость
        private int _shield;  // защита
    }
}
