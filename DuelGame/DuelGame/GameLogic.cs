using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class GameLogic
    {
        
        /// <summary>
        /// ход игры
        /// </summary>
        /// <param name="a">первый игрок</param>
        /// <param name="b">второй игрок</param>
        public void Duel(Personage a, Personage b)
        {
            Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}", a.Name, a.Live, a.Force, a.Protection);
            Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}", b.Name, b.Live, b.Force, b.Protection);
            int hitA;
            int protA;

            int hitB;
            int protB;

            do
            {
                hitA = a.GetHitValueForStep();
                protA = a.GetProtectionValueForStep();

                hitB = b.GetHitValueForStep();
                protB = b.GetProtectionValueForStep();
                if (b.CheckLive())
                {
                    a.CompareValues(protA, hitB);
                }
                if (a.CheckLive())
                {
                    b.CompareValues(protB, hitA);
                }
                             

                Console.WriteLine("{0} - жизни осталось: {1}", a.Name, a.Live);
                Console.WriteLine("{0} - жизни осталось: {1}", b.Name, b.Live);

            } while (a.Live > 0 && b.Live > 0);

            if (a.Live > 0)
            {
                Console.WriteLine("{0} - ты выиграл!", a.Name);
            }
            else
            {
                Console.WriteLine("{0} - ты выиграл!", b.Name);
            }
            
        }

     
    }
}
