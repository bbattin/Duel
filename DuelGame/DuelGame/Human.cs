using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Human : Personage
    {
        private int _ingenuity = 2;

        public Human()
        {
            live = 9;
            force = 3;
            protection = 2;
            adroitness = 4;
            accuracy = 3;
            educability = 8;
        }

        protected override void ToAttack()
        {
            throw new NotImplementedException();
        }

        protected override void ToProtection()
        {
            throw new NotImplementedException();
        }

        protected override void UseFeatures()
        {
            throw new NotImplementedException();
        }
    }
}
