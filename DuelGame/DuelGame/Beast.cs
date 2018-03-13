using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Beast : Personage
    {
        private int _restoring = 1;

        public Beast()
        {
            live = 15;
            force = 8;
            protection = 8;
            adroitness = 5;
            accuracy = 5;
            educability = 2;
        }
                
    }
}
