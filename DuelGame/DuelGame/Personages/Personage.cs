using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Personage
    {
        
        public int Live { get; protected set; }                   // жизнь
        public int Force { get; protected set; }                  // сила
        public int Protection { get; protected set; }             // защита
        public string Name { get ; protected set; }               // имя персонажа
        public Weapons WeaponsPersonage { get; set; }             // оружие персонажа

        ///// <summary>
        ///// проверка на остаток жизни персонажа перед ходом
        ///// </summary>
        ///// <returns></returns>
        //public bool CheckLive()  
        //{
        //    bool live = false;

        //    if (Live > 0)
        //    {
        //        live = true;
        //    }
        //    else
        //    {
        //        throw new Exception(string.Format("Персонаж {0} уже мертв и напасть не может.", this));  // собственные исключения, отдельным классом
        //    }
        //    return live;
        //}


        /// <summary>
        /// сравниваем силу с защитой и отнимаем урон от жертвы
        /// </summary>
        /// <param name="protA">защита жертвы</param>
        /// <param name="hitB">сила противника</param>
        public void CompareValues(int protA, int hitB) 
        {
            if (protA > hitB)
            {
                Live = Live - 1;

            }
            else
            {
                Live = Live - (hitB - protA);
            }
        }

        /// <summary>
        /// значение защиты для шага, учитывая рандом защиты из-за ловкости
        /// </summary>
        /// <returns></returns>
        public int GetProtectionValueForStep()
        {
            return (int)Math.Round(Protection * GetRandomFromInterval(0.2, 1.2) + WeaponsPersonage.Protection);
        }

        /// <summary>
        /// значение силы для шага, учитывая рандом урона из-за меткости
        /// </summary>
        /// <returns></returns>
        public int GetHitValueForStep()
        {
            return (int)Math.Round(Force * GetRandomFromInterval(0.5, 1.5) + WeaponsPersonage.Damage);
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

        private Random rand = new Random();
    }
}
