using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    abstract class Equipment : ICharacteristic
    {
        public int Live { get; set; }
        public int Force { get; set; }
        public int Protection { get; set; }
        public int Adroitness { get; set; }
        public int Accuracy { get; set; }
        public string Name { get; set; }

    }
}
