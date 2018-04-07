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

            //Magician a = new Magician();
            //Beast b = new Beast();

            //GameLogic game = new GameLogic();

            //try
            //{
            //    game.Duel(a, b);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Конец игры");
            //}

            Console.ReadKey();
        }

       
    }
}
