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
        public Human()
        {
            Name = "Человек";
            Live = 90;
            Force = 5;
            Protection = 4;
        }

    }
}
