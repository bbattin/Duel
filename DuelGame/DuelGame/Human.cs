using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Human : Personage
    {
        private int _ingenuity = 2;

        public Human(string name)
        {
            Name = name;
            Live = 9;
            Force = 3;
            Protection = 2;
            Adroitness = 4;
            Accuracy = 3;
            Educability = 8;
        }

       
    }
}
