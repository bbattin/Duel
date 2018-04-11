using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Personage user = UI.GetPersonageForUser();
            user.WeaponsPersonage = UI.GetWeaponsForUser();

            Console.Clear();

            GameLogic game = new GameLogic();
            UI eventsGame = new UI(game);
            
            game.Duel(user);

          
            Console.ReadKey();
        }

       
    }
}
