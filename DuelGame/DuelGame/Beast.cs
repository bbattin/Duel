using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Beast : Personage
    {
        public Beast(string name)
        {
            Name = name;
            Live = 150;
            Force = 8;
            Protection = 7;
            Adroitness = 4;
            Accuracy = 4;
            //Educability = 2;
        }

        //private int _restoring = 1;

    }
}
