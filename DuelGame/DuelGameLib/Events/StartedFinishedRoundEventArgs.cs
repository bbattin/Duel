using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class StartedFinishedRoundEventArgs : EventArgs
    {
        public StartedFinishedRoundEventArgs(Personage uzer, Personage rand)
        {
            NameUzer = uzer.Name;
            NameRand = rand.Name;
            LiveUzer = uzer.Live;
            LiveRand = rand.Live;
        }

        // данные, описывающие событие
        public int LiveUzer { get; private set; } // значение жизни персонажа пользователя
        public int LiveRand { get; private set; } // значение жизни рандомного персонажа
        public string NameUzer { get; private set; }         // имя персонажа пользователя
        public string NameRand { get; private set; }         // имя рандомного персонажа
    }
}
