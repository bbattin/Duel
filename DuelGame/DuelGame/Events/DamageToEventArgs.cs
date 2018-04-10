using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class DamageToEventArgs : EventArgs
    {
        public DamageToEventArgs(int damageV)
        {
            DamageValue = damageV;
        }

        // данные, описывающие событие
        public int DamageValue { get; private set; } // значение нанесенного ущерба
        
    }
}
