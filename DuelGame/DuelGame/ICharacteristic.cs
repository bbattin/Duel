using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    interface ICharacteristic
    {
        int live { get; set; }              // жизнь
        int force { get; set; }             // сила
        int protection { get; set; }        // защита
        int adroitness { get; set; }        // ловкость
        int accuracy { get; set; }          // точность, меткость
        int educability { get; set; }       // обучаемость
    }
}
