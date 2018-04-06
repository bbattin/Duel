using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Weapon
        // броня
    {
        public int Light { get; set ; }     // легкость
        public int Shield { get ; set ; }   // защита

        /// <summary>
        /// получение цифры защиты
        /// </summary>
        /// <returns></returns>
        abstract protected int GetTotalShield();

    }
}
