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
            Name = "Перчатки-когти + броня - комлект 3";
            Damage = 2;
            Protection = 5;
        }
    }
}
