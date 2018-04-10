using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class StartedFinishedRoundEventArgs
    {
        public StartedFinishedRoundEventArgs(Personage uzer, Personage rand)
        {
            LiveUzer = uzer.Live;
            LiveRand = rand.Live;
        }

        // данные, описывающие событие
        public int LiveUzer { get; private set; } // значение жизни персонажа пользователя
        public int LiveRand { get; private set; } // значение жизни рандомного персонажа
    }
}
