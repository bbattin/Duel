using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Magician : Personage
        // маг
    {
        public Magician(string name)
        {
            Name = name;
            Live = 110;
            Force = 6;
            Protection = 5;
        }
        
    }
}
