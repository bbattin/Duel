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
            int hitA;
            int protA;

            int hitB;
            int protB;

            do
            {
                hitA = userPer.GetHitValueForStep();
                protA = userPer.GetProtectionValueForStep();

                hitB = randomPer.GetHitValueForStep();
                protB = randomPer.GetProtectionValueForStep();
                //if (randomPer.CheckLive())
                //{
                    userPer.CompareValues(protA, hitB);
                //}
                //if (userPer.CheckLive())
                //{
                    randomPer.CompareValues(protB, hitA);
                //}
                             

                Console.WriteLine("{0} - жизни осталось: {1}", userPer.Name, userPer.Live);
                Console.WriteLine("{0} - жизни осталось: {1}", randomPer.Name, randomPer.Live);

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
