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
            Human a = new Human();
            Beast b = new Beast();
            Magician c = new Magician();
            Console.WriteLine("Выберите персонажа для игры:");
            Console.WriteLine("{0} (жизнь - {1}, сила - {2}, защита {3} - нажмите 1)", a.Name, a.Live, a.Force, a.Protection);
            Console.WriteLine("{0} (жизнь - {1}, сила - {2}, защита {3} - нажмите 2)", b.Name, b.Live, b.Force, b.Protection);
            Console.WriteLine("{0} (жизнь - {1}, сила - {2}, защита {3} - нажмите 3)", c.Name, c.Live, c.Force, c.Protection);
            string pers = Console.ReadLine();
            Personage d;
            switch (pers)
            {
                case "1":
                    Console.WriteLine("Выбран персонаж {0}.", a.Name);
                    d = a;
                    break;
                case "2":
                    Console.WriteLine("Выбран персонаж {0}.", b.Name);
                    d = b;
                    break;
                case "3":
                    Console.WriteLine("Выбран персонаж {0}.", c.Name);
                    d = c;
                    break;
                default:
                    Console.WriteLine("Ошибка: введена неверная цифра. Вам выбран по умолчанию персонаж Человек.");
                    d = a;
                    break;
            }
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
