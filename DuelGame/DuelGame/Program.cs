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
            Console.WriteLine("Выберите персонажа для игры:");
            Console.WriteLine("Человек - нажмите 1");
            Console.WriteLine("Зверь - нажмите 2");
            Console.WriteLine("Маг - нажмите 3");
            string pers = Console.ReadLine();

            Console.WriteLine("Выберите комплект снаряжения для игры:");
            Console.WriteLine("Меч (+5 к урону), щит(+3 к защите) - нажмите 1");
            Console.WriteLine("Посох (+8 к урону), мантия (+1 к защите) - нажмите 2");
            Console.WriteLine("Перчатки-когти (+2 к урону), броня(+4 к защите) - нажмите 3");
            Console.WriteLine("Лук и стрелы (+4 к урону), легкая обувь(+2 к защите) - нажмите 4");
            Console.WriteLine("Кувалда (+5 к урону), шлем(+3 к защите) - нажмите 5");
            string equipment = Console.ReadLine();

            Magician a = new Magician("Bob");
            Beast b = new Beast("Rex");

            GameLogic game = new GameLogic();

            try
            {
                game.Duel(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
