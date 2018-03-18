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

        public Magician(string name)
        {
            Name = name;
            Live = 11;
            Force = 6;
            Protection = 5;
            Adroitness = 3;
            Accuracy = 7;
            Educability = 5;
        }

       
    }
}
