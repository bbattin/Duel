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
        /// <param name="userPer">первый игрок</param>
        /// <param name="random">второй игрок</param>
        public static void Duel(Personage userPer)
        {
            Personage randomPer = GetRandomPersonage();
            Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}", userPer.Name, userPer.Live, userPer.Force, userPer.Protection);
            Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}", randomPer.Name, randomPer.Live, randomPer.Force, randomPer.Protection);
            int damageUzer;
            int damageRandom;
            do
            {
                damageUzer = GetRezultDamage(userPer.GetProtectionValueForStep(), randomPer.GetHitValueForStep());
                damageRandom = GetRezultDamage(randomPer.GetProtectionValueForStep(), userPer.GetHitValueForStep());
                userPer.SetLiveAfterDamage(damageUzer);
                randomPer.SetLiveAfterDamage(damageRandom);
                //Console.WriteLine("{0} - жизни осталось: {1}", userPer.Name, userPer.Live);
                //Console.WriteLine("{0} - жизни осталось: {1}", randomPer.Name, randomPer.Live);

            } while (userPer.Live > 0 && randomPer.Live > 0);

            if (userPer.Live > 0)
            {
                Console.WriteLine("{0} - ты выиграл!", userPer.Name);
            }
            else
            {
                Console.WriteLine("{0} - ты выиграл!", randomPer.Name);
            }
            
        }

        /// <summary>
        /// сравниваем силу с защитой и отнимаем урон от жертвы
        /// </summary>
        /// <param name="protA">защита жертвы</param>
        /// <param name="hitB">сила противника</param>
        private static int GetRezultDamage(int protA, int hitB)
        {
            int damage;

            if (protA > hitB)
            {
                damage = 1;

            }
            else
            {
                damage = hitB - protA;
            }
            return damage;
        }


        private static Personage GetRandomPersonage()
        {
            Personage d = null;
            int num = rand.Next(1, 3);
            switch (num)
            {
                case 1:
                    d = new Human();
                    break;
                case 2:
                    d = new Beast();
                    break;
                case 3:
                    d = new Magician();
                    break;         
            }
            int numW = rand.Next(1, 5);
            switch (numW)
            {
                case 1:
                    d.WeaponsPersonage = new SwordAndShield();
                    break;
                case 2:
                    d.WeaponsPersonage = new StaffAndMantle();
                    break;
                case 3:
                    d.WeaponsPersonage = new ClawGlovesAndArmor();
                    break;
                case 4:
                    d.WeaponsPersonage = new BowArrowAndLightShoes();
                    break;
                case 5:
                    d.WeaponsPersonage = new SledgeHammerAndHelmet();
                    break;
            }
            return d;
        }

        private static Random rand = new Random();

    }
}
