using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class DamageToEventArgs : EventArgs
    {
        public DamageToEventArgs(int damageValForUser, int damageValForRand)
        {
            DamageValueForUser = damageValForUser;
            DamageValueForRand = damageValForRand;
        }

        // данные, описывающие событие
        public int DamageValueForUser { get; private set; } // значение нанесенного ущерба
        public int DamageValueForRand { get; private set; } // значение нанесенного ущерба

    }
}
