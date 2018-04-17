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
            Personage user = null;
            while(user == null)
            {
                try
                {
                    user = UI.GetPersonageForUser();
                }
                catch (InputUserPersonageException ex)
                {
                    Console.WriteLine("{0} {1}", ex.CreatedDate, ex.Message);
                }
            }

            UI.GetNamePersonageForUser(user);

            while (user.WeaponsPersonage == null)
            {
                try
                {
                    user.WeaponsPersonage = UI.GetWeaponsForUser();
                }
                catch (InputUserPersonageException ex)
                {
                    Console.WriteLine("{0} {1}", ex.CreatedDate, ex.Message);
                }
            }

            Console.Clear();

            GameLogic game = new GameLogic();
            UI eventsGame = new UI(game);

            game.Duel(user);

            Console.ReadKey();
        }

       
    }
}
