using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    delegate void StartedGame(object sender, StartedFinishedGameEventArgs args);
    delegate void FinishedGame(object sender, StartedFinishedGameEventArgs args);

    delegate void StartedRound(object sender, StartedFinishedRoundEventArgs args);
    delegate void FinishedRound(object sender, StartedFinishedRoundEventArgs args);

    delegate void DamageToPersonage(object sender, DamageToEventArgs args);


    class GameLogic
    {
               
        /// <summary>
        /// ход игры
        /// </summary>
        /// <param name="userPer">первый игрок</param>
        /// <param name="random">второй игрок</param>
        public void Duel(Personage userPer)
        {
            Personage randomPer = GetRandomPersonage();
            
            OnStartedG(userPer, randomPer);
            int damageForUzer;
            int damageForRandom;
            do
            {
                OnStartedR(userPer, randomPer);
                
                System.Threading.Thread.Sleep(600);
                damageForUzer = GetRezultDamage(userPer.GetProtectionValueForStep(), randomPer.GetHitValueForStep());
                damageForRandom = GetRezultDamage(randomPer.GetProtectionValueForStep(), userPer.GetHitValueForStep());
                userPer.SetLiveAfterDamage(damageForUzer);
                randomPer.SetLiveAfterDamage(damageForRandom);
                ToDamage(damageForUzer);
                ToDamage(damageForRandom);
                OnFinishedR(userPer, randomPer);

            } while (userPer.Live > 0 && randomPer.Live > 0);
            OnFinishedG(userPer, randomPer);
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

        public void ToDamage(int damageV)
        {
            if (_damage != null)
            {
                _damage(this, new DamageToEventArgs(damageV));
            }
        }

        public void OnStartedG(Personage uzer, Personage rand)
        {
            if (_startG != null)
            {
                _startG(this, new StartedFinishedGameEventArgs(uzer, rand));
            }
        }

        public void OnFinishedG(Personage uzer, Personage rand)
        {
            if (_finishG != null)
            {
                _finishG(this, new StartedFinishedGameEventArgs(uzer, rand));
            }
        }

        public void OnStartedR(Personage uzer, Personage rand)
        {
            if (_startR != null)
            {
                _startR(this, new StartedFinishedRoundEventArgs(uzer, rand));
            }
        }

        public void OnFinishedR(Personage uzer, Personage rand)
        {
            if (_finishR != null)
            {
                _finishR(this, new StartedFinishedRoundEventArgs(uzer, rand));
            }
        }


       
        /// <summary>
        /// сравниваем силу с защитой и получаем значение урона
        /// </summary>
        /// <param name="protA">защита жертвы</param>
        /// <param name="hitB">сила противника</param>
        private int GetRezultDamage(int protA, int hitB)
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


        private Personage GetRandomPersonage()
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
        private StartedGame _startG;
        private FinishedGame _finishG;
        private StartedRound _startR;
        private FinishedRound _finishR;
        private DamageToPersonage _damage;
    }
}
