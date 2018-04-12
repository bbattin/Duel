using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    interface IGame
    {
        void Duel(Personage userPer);
        event StartedGame StartedG;
        event FinishedGame FinishedG;
        event StartedRound StartedR;
        event DamageToPersonage Damage;
        void ToDamage(int damageVForUser, int damageVForRand);
        void OnStartedG(Personage uzer, Personage rand);
        void OnFinishedG(Personage uzer, Personage rand);
        void OnStartedR(Personage uzer, Personage rand);
        
    }
}
