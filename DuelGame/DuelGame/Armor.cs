using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Armor
        // оружие
    {
        
        public int Aiming { get ; set ; }      // прицельность
        
        /// <summary>
        /// получение цифры урона
        /// </summary>
        /// <returns></returns>
        abstract protected int GetTotalDamage(); 

    }
}
 