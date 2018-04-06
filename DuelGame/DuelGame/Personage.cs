using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Personage
    {
        
        public int Live { get; set; }            // жизнь
        public int Force { get; set; }           // сила
        public int Protection { get; set; }      // сила
        public Adroitness Adroitness { get; set; }      // ловкость
        public Accuracy Accuracy { get; set; }        // меткость
        public string Name { get ; set ; }       // имя персонажа

    }
}
