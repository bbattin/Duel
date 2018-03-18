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

        public Beast(string name)
        {
            Name = name;
            Live = 15;
            Force = 8;
            Protection = 8;
            Adroitness = 5;
            Accuracy = 5;
            Educability = 2;
        }

        
    }
}
