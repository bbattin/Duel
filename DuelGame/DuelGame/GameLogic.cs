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
                hitA = GetHitValueForStep(a);
                protA = GetProtectionValueForStep(a);

                hitB = GetHitValueForStep(b);
                protB = GetProtectionValueForStep(b);

                CompareValues(a, protA, hitB);
                CompareValues(b, protB, hitA);
                
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

        private static void CompareValues(Personage a, int protA, int hitB)
        {
            if (protA > hitB)
            {
                a.Live = a.Live - 1;

            }
            else
            {
                a.Live = a.Live - (hitB - protA);
            }
        }

        private int GetProtectionValueForStep(Personage a)
        {
            return (int)(a.Protection * Math.Round(a.Adroitness * GetRandomFromInterval(0.2, 1.0)));
        }

        private int GetHitValueForStep(Personage a)
        {
            return (int)(a.Force * Math.Round(a.Accuracy * GetRandomFromInterval(0.2, 1.0)));
        }

        private double GetRandomFromInterval(double lowerBound, double upperBound)
        {
            return rand.NextDouble() * (upperBound - lowerBound) + lowerBound;
        }
    }
}
