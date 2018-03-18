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
            Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}, меткость {4}, ловкость {5}", a.Name, a.Live, a.Force, a.Protection, a.Accuracy, a.Adroitness);
            Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}, меткость {4}, ловкость {5}", b.Name, b.Live, b.Force, b.Protection, b.Accuracy, b.Adroitness);

            do
            {
                a.Live = a.Live - Math.Abs(b.Force * b.Accuracy - a.Protection * a.Adroitness);
                b.Live = b.Live - Math.Abs(a.Force * a.Accuracy - b.Protection * b.Adroitness);
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
