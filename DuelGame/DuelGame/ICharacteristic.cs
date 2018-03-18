﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    interface ICharacteristic
    {
        int Live { get; set; }              // жизнь
        int Force { get; set; }             // сила
        int Protection { get; set; }        // защита
        int Adroitness { get; set; }        // ловкость
        int Accuracy { get; set; }          // точность, меткость
        int Educability { get; set; }       // обучаемость
    }
}
