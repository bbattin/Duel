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

        
        /// <summary>
        /// ход игры
        /// </summary>
        /// <param name="a">первый игрок</param>
        /// <param name="b">второй игрок</param>
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
                if (CheckLive(b, a))
                {
                    CompareValues(a, protA, hitB);
                }
                if (CheckLive(a, b))
                {
                    CompareValues(b, protB, hitA);
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

        /// <summary>
        /// проверка на остаток жизни персонажа перед ходом
        /// </summary>
        /// <param name="a">персонаж, который проверяем</param>
        /// <param name="b">соперник</param>
        /// <returns></returns>
        private static bool CheckLive(Personage a, Personage b)  // в класс Персонаж isLive
        {
            bool live = false;

            if (a.Live > 0)
            {
                live = true;
            }
            else
            {
                throw new Exception(string.Format("Персонаж {0} уже мертв и напасть не может. {1} выиграл!", a.Name, b.Name));  // собственные исключения, отдельным классом
            }
            return live;
        }

        /// <summary>
        /// сравниваем силу с защитой и отнимаем урон от жертвы
        /// </summary>
        /// <param name="a">жертва</param>
        /// <param name="protA">защита жертвы</param>
        /// <param name="hitB">сила противника</param>
        private static void CompareValues(Personage a, int protA, int hitB) // вынести в класс персонаж
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

        /// <summary>
        /// значение защиты для шага, учитывая рандом ловкости
        /// </summary>
        /// <param name="a">персонаж</param>
        /// <returns></returns>
        private int GetProtectionValueForStep(Personage a)
        {
            return (int)(a.Protection * Math.Round(a.Adroitness * GetRandomFromInterval(0.2, 1.0)));
        }

        /// <summary>
        /// значение силы для шага, учитывая рандом меткости
        /// </summary>
        /// <param name="a">персонаж</param>
        /// <returns></returns>
        private int GetHitValueForStep(Personage a)
        {
            return (int)(a.Force * Math.Round(a.Accuracy * GetRandomFromInterval(0.2, 1.0)));
        }

        /// <summary>
        /// получение рандома double чисел с указанием интервала
        /// </summary>
        /// <param name="lowerBound">начальное значение</param>
        /// <param name="upperBound">конечное значение</param>
        /// <returns></returns>
        private double GetRandomFromInterval(double lowerBound, double upperBound)
        {
            return rand.NextDouble() * (upperBound - lowerBound) + lowerBound;
        }
    }
}
