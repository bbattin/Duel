using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Magician : Personage
    {
        private int _magic = 3;

        public Magician()
        {
            live = 11;
            force = 6;
            protection = 5;
            adroitness = 3;
            accuracy = 7;
            educability = 5;
        }
    }
}
