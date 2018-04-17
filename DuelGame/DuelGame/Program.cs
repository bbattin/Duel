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
            try
            {
                Personage user = UI.GetPersonageForUser();
                user.WeaponsPersonage = UI.GetWeaponsForUser();
                Console.Clear();

                GameLogic game = new GameLogic();
                UI eventsGame = new UI(game);

                game.Duel(user);
            }
            catch (InputUzerException ex)
            {
                Console.WriteLine("{0} {1}", ex.CreatedDate, ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Конец игры");
            }

                      
            Console.ReadKey();
        }

       
    }
}
