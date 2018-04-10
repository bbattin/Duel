using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class UI
    {
        public static Personage GetPersonageForUser()
        {
            Console.WriteLine("Выберите персонажа для игры:");
            Console.WriteLine("Человек (жизнь 100, сила 5, защита 7) - нажмите 1");
            Console.WriteLine("Зверь (жизнь 110, сила 8, защита 5) - нажмите 2");
            Console.WriteLine("Маг (жизнь 105, сила 6, защита 6) - нажмите 3");
            string pers = Console.ReadLine();
            Console.WriteLine("Введите имя персонажа: ");
            string name = Console.ReadLine();
            Personage d;
            switch (pers)
            {
                case "1":
                    Console.WriteLine("Выбран персонаж Человек");
                    d = new Human();
                    break;
                case "2":
                    Console.WriteLine("Выбран персонаж Зверь");
                    d = new Beast();
                    break;
                case "3":
                    Console.WriteLine("Выбран персонаж Маг");
                    d = new Magician();
                    break;
                default:
                    Console.WriteLine("Ошибка: введена неверная цифра. Вам выбран по умолчанию персонаж Человек.");
                    d = new Human();
                    break;
            }
            d.Name = name;
            return d;
        }

        public static Weapons GetWeaponsForUser()
        {
            Console.WriteLine();
            Console.WriteLine("Выберите комплект снаряжения для игры:");
            Console.WriteLine("Меч (+5 к урону), щит(+4 к защите) - нажмите 1");
            Console.WriteLine("Посох (+8 к урону), мантия (+1 к защите) - нажмите 2");
            Console.WriteLine("Перчатки-когти (+2 к урону), броня(+5 к защите) - нажмите 3");
            Console.WriteLine("Лук и стрелы (+4 к урону), легкая обувь(+2 к защите) - нажмите 4");
            Console.WriteLine("Кувалда (+6 к урону), шлем(+3 к защите) - нажмите 5");
            string equipment = Console.ReadLine();
            Weapons d;
            switch (equipment)
            {
                case "1":
                    Console.WriteLine("Выбран первый комплект.");
                    d = new SwordAndShield();
                    break;
                case "2":
                    Console.WriteLine("Выбран второй комплект.");
                    d = new StaffAndMantle();
                    break;
                case "3":
                    Console.WriteLine("Выбран третий комплект.");
                    d = new ClawGlovesAndArmor();
                    break;
                case "4":
                    Console.WriteLine("Выбран четвертый комплект.");
                    d = new BowArrowAndLightShoes();
                    break;
                case "5":
                    Console.WriteLine("Выбран пятый комплект.");
                    d = new SledgeHammerAndHelmet();
                    break;
                default:
                    Console.WriteLine("Ошибка: введена неверная цифра. Вам выбран по умолчанию первый комплект.");
                    d = new SwordAndShield();
                    break;
            }
            return d;
        }
    }
}
