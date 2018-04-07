using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Beast : Personage
        // зверь
    {
        public Beast()
        {
            Name = "Зверь";
            Live = 150;
            Force = 8;
            Protection = 7;
        }

    }
}
