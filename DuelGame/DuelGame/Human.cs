using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Human : Personage
        // человек
    {
        public Human(string name)
        {
            Name = name;
            Live = 90;
            Force = 3;
            Protection = 2;
        }

    }
}
