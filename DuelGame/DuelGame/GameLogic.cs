using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class GameLogic
    {
        public static void Duel(Personage a, Personage b)
        {
            Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}", a.Name, a.Live, a.Force, a.Protection);
            Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}", b.Name, b.Live, b.Force, b.Protection);

            do
            {
                a.Live = a.Live - Math.Abs(b.Force - a.Protection);
                b.Live = b.Live - Math.Abs(a.Force - a.Protection);
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
