using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Human : Personage
    {
        public Human(string name)
        {
            Name = name;
            Live = 90;
            Force = 3;
            Protection = 2;
            Adroitness = 4;
            Accuracy = 3;
            //Educability = 8;
        }

        //private int _ingenuity = 2;
    }
}
