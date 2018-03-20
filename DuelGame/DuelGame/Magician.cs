using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Magician : Personage
    {
        public Magician(string name)
        {
            Name = name;
            Live = 110;
            Force = 6;
            Protection = 5;
            Adroitness = 5;
            Accuracy = 7;
            //Educability = 5;
        }

        private int _magic = 3;
    }
}
