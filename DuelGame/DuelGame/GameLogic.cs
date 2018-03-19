using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class GameLogic
    {
        public Random rand = new Random();

        public double GetRandomFromInterval(double lowerBound, double upperBound)
        {
            return rand.NextDouble() * (upperBound - lowerBound) + lowerBound;
        }

        public void Duel(Personage a, Personage b)
        {
            Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}, меткость {4}, ловкость {5}", a.Name, a.Live, a.Force, a.Protection, a.Accuracy, a.Adroitness);
            Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}, меткость {4}, ловкость {5}", b.Name, b.Live, b.Force, b.Protection, b.Accuracy, b.Adroitness);
            int hitA;
            int protA;

            int hitB;
            int protB;

            do
            {
                hitA = (int)Math.Round(a.Force * (a.Accuracy * GetRandomFromInterval(0.2, 1.0)));
                protA = (int)Math.Round(a.Protection * (a.Adroitness * GetRandomFromInterval(0.2, 1.0)));

                hitB = (int)Math.Round(b.Force * (b.Accuracy * GetRandomFromInterval(0.2, 1.0)));
                protB = (int)Math.Round(b.Protection * (b.Adroitness * GetRandomFromInterval(0.2, 1.0)));

                if (protA > hitB)
                {
                    a.Live = a.Live - 1;
                    
                }
                else
                {
                    a.Live = a.Live - (hitB - protA);
                }
                if (protB > hitA)
                {
                    b.Live = b.Live - 1;

                }
                else
                {
                    b.Live = b.Live - (hitA - protB);
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
