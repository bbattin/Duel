using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class StartedFinishedGameEventArgs : EventArgs
    {
        public StartedFinishedGameEventArgs(Personage uzer, Personage rand)
        {
            NameUzer = uzer.Name;
            NameRand = rand.Name;
            LiveUzer = uzer.Live;
            LiveRand = rand.Live;
            ForceUzer = uzer.Force;
            ForceRand = rand.Force;
            ProtectionUzer = uzer.Protection;
            ProtectionRand = rand.Protection;
            DamageWUzer = uzer.WeaponsPersonage.Damage;
            DamageWRand = rand.WeaponsPersonage.Damage;
            ProtectionWUzer = uzer.WeaponsPersonage.Protection;
            ProtectionWRand = rand.WeaponsPersonage.Protection;
        }

        // данные, описывающие событие
        public string NameUzer { get; private set; }         // имя персонажа пользователя
        public string NameRand { get; private set; }         // имя рандомного персонажа
        public int LiveUzer { get; private set; }         // значение жизни персонажа пользователя
        public int LiveRand { get; private set; }         // значение жизни рандомного персонажа
        public int ForceUzer { get; private set; }        // значение силы персонажа пользователя
        public int ForceRand { get; private set; }        // значение силы рандомного персонажа
        public int ProtectionUzer { get; private set; }   // значение защиты персонажа пользователя
        public int ProtectionRand { get; private set; }   // значение защиты рандомного персонажа

        public int DamageWUzer { get; private set; }        // значение урона от оружия персонажа пользователя
        public int DamageWRand { get; private set; }        // значение урона от оружия рандомного персонажа
        public int ProtectionWUzer { get; private set; }   // значение защиты от оружия персонажа пользователя
        public int ProtectionWRand { get; private set; }   // значение защиты от оружия рандомного персонажа

    } 
}
