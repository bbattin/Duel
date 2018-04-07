using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class ClawGlovesAndArmor : Weapons
    // перчатки-когти + броня - комлект 3
    {
        public ClawGlovesAndArmor()
        {
            Damage = 4;
            Protection = 5;
        }
    }
}
