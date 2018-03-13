using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Personage
    {
        private int _live;              // жизнь
        private int _force;             // сила
        private int _protection;        // защита
        private int _adroitness;        // ловкость
        private int _accuracy;          // точность, меткость
        private int _educability;       // обучаемость
        private int _money = 5;         // деньги на покупку оружия/брони

        List<Equipment> equipment;
    }
}
