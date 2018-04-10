using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    delegate void DamageToPersonage(object sender, DamageToEventArgs args);
    
    delegate void StartedGame(object sender, StartedFinishedGameEventArgs args);
    delegate void FinishedGame(object sender, StartedFinishedGameEventArgs args);

    delegate void StartedRound(object sender, StartedFinishedRoundEventArgs args);
    delegate void FinishedRound(object sender, StartedFinishedRoundEventArgs args);


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
            //Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}", userPer.Name, userPer.Live, userPer.Force, userPer.Protection);
            //Console.WriteLine("{0} - жизнь {1}, сила {2}, защита {3}", randomPer.Name, randomPer.Live, randomPer.Force, randomPer.Protection);
            int damageForUzer;
            int damageForRandom;
            do
            {
                damageForUzer = GetRezultDamage(userPer.GetProtectionValueForStep(), randomPer.GetHitValueForStep());
                damageForRandom = GetRezultDamage(randomPer.GetProtectionValueForStep(), userPer.GetHitValueForStep());
                userPer.SetLiveAfterDamage(damageForUzer);
                randomPer.SetLiveAfterDamage(damageForRandom);

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


        public event DamageToPersonage Damage
        {
            add
            {
                _damage += value;
            }
            remove
            {
                _damage -= value;
            }
        }

        public event StartedGame StartedG
        {
            add
            {
                _startG += value;
            }
            remove
            {
                _startG -= value;
            }
        }

        public event FinishedGame FinishedG
        {
            add
            {
                _finishG += value;
            }
            remove
            {
                _finishG -= value;
            }
        }

        public event StartedRound StartedR
        {
            add
            {
                _startR += value;
            }
            remove
            {
                _startR -= value;
            }
        }

        public event FinishedRound FinishedR
        {
            add
            {
                _finishR += value;
            }
            remove
            {
                _finishR -= value;
            }
        }

        public void ToDamage()
        {
            if (_damage != null)
            {
                _damage(this, new DamageToEventArgs());
            }
        }

        public void OnStartedG()
        {
            if (_startG != null)
            {
                _startG(this, new StartedFinishedGameEventArgs());
            }
        }

        public void OnFinishedG()
        {
            if (_finishG != null)
            {
                _finishG(this, new StartedFinishedGameEventArgs());
            }
        }

        public void OnStartedR()
        {
            if (_startR != null)
            {
                _startR(this, new StartedFinishedRoundEventArgs());
            }
        }

        public void OnFinishedR()
        {
            if (_finishG != null)
            {
                _finishR(this, new StartedFinishedRoundEventArgs());
            }
        }


        private DamageToPersonage _damage;
        private StartedGame _startG;
        private FinishedGame _finishG;
        private StartedRound _startR;
        private FinishedRound _finishR;

        /// <summary>
        /// сравниваем силу с защитой и получаем значение урона
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
