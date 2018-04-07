using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class BowArrowAndLightShoes : Weapons
        // лук и стрелы + легкая обувь - комлпект 4
    {
        public BowArrowAndLightShoes()
        {
            Damage = 4;
            Protection = 5;
        }
    }
}
