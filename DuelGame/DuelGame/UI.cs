﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class UI
    {
        public UI(GameLogic p)
        {
            //p.StartedG += Start;
            p.FinishedG += FinishGame;
            //p.StartedR += OnNextMoved;
            //p.FinishedR += Finish;

        }

        public UI(Personage p)
        {
            p.Damage += OnNextDamage;
            DamageCounter = 0;
        }

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


        public void OnNextDamage(object sender, DamageToEventArgs args)
        {
            DamageCounter++;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Нанесенный урон {0}", args.DamageValue);
        }

        public void FinishGame(object sender, StartedFinishedGameEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Количество ходов всего во время боя {0}", DamageCounter);
            Console.WriteLine("Жизни осталось у {0} {1}, {2} - {3}", args.NameUzer, args.LiveUzer, args.NameRand, args.LiveRand);

            if (args.LiveUzer > args.LiveRand)
            {
                Console.WriteLine("Выиграл {0}", args.NameUzer);
                Console.WriteLine("Проиграл {0}", args.NameRand);
            }
            else
            {
                Console.WriteLine("Выиграл {0}", args.NameRand);
                Console.WriteLine("Проиграл {0}", args.NameUzer);
            }

            TimeSpan ts = StopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Длительность игры " + elapsedTime);
        }

        //public void Start(object sender, StartedFinishedEventArgs args)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("Start");
        //    Console.WriteLine("Date now {0}", args.CreatedDate);
        //    StopWatch.Start();
        //}

        //public void Finish(object sender, StartedFinishedEventArgs args)
        //{
        //    StopWatch.Stop();
        //    args.FinishDate = DateTime.Now;
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("Finish");
        //    Console.WriteLine("Date now {0}", args.FinishDate);
        //}

        private int DamageCounter { get; set; }
        private Stopwatch StopWatch { get; set; }
    }
}
