using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace DuelGame
{
    [DataContract]  // сериализация в Json
    class Personage
    {
        [DataMember]
        public int Live { get; protected set; }                   // жизнь
        [DataMember]
        public int Force { get; protected set; }                  // сила
        [DataMember]
        public int Protection { get; protected set; }             // защита
        [DataMember]
        public string Name { get ; set; }                         // имя персонажа
        public Weapons WeaponsPersonage { get; set; }             // оружие персонажа

         
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
        /// отнимаем урон от жертвы
        /// </summary>
        /// <param name="damage">урон</param>
        public void SetLiveAfterDamage(int damage)
        {
            if(damage < Live)
            {
                Live = Live - damage;
            }
            else
            {
                Live = 0;
            }
                        
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
