using System;
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
            p.StartedG += StartGame;
            p.FinishedG += FinishGame;
            p.StartedR += StartRound;
           
            p.Damage += OnNextDamage;
            RoundsCounter = 0;
            StopWatch = new Stopwatch();
        }

       

        public static Personage GetPersonageForUser()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Игра Duel");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Выберите персонажа для игры:");
            Console.WriteLine("Человек (жизнь 100, сила 5, защита 7) - нажмите 1");
            Console.WriteLine("Зверь (жизнь 110, сила 8, защита 5) - нажмите 2");
            Console.WriteLine("Маг (жизнь 105, сила 6, защита 6) - нажмите 3");
            string pers = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите имя персонажа: ");
            string name = Console.ReadLine();
            Console.WriteLine();
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

        public void StartGame(object sender, StartedFinishedGameEventArgs args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Информация об игроках");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Игрок первый");
            Console.WriteLine("Имя {0}, жизнь {1}, сила {2}, защита {3}", args.NameUzer, args.LiveUzer, args.ForceUzer, args.ProtectionUzer);
            Console.WriteLine("Оружие первого игрока");
            Console.WriteLine("Название {0}, урон {1}, защита {2}", args.NameWUzer, args.DamageWUzer, args.ProtectionWUzer);

            Console.WriteLine();
            Console.WriteLine("Игрок второй");
            Console.WriteLine("Имя {0}, жизнь {1}, сила {2}, защита {3}", args.NameRand, args.LiveRand, args.ForceRand, args.ProtectionRand);
            Console.WriteLine("Оружие первого игрока");
            Console.WriteLine("Название {0}, урон {1}, защита {2}", args.NameWRand, args.DamageWRand, args.ProtectionWRand);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.Clear();
            StopWatch.Start();
        }

        public void StartRound(object sender, StartedFinishedRoundEventArgs args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("Бой. Раунд {0}", RoundsCounter + 1);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Имя {0}", args.NameUzer);
            Console.WriteLine("Жизнь {0} ", args.LiveUzer);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Green;
            
            for (int i = 0; i < args.LiveUzer/2; i++)
            {
                Console.Write("*");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Имя {0}", args.NameRand);
            Console.WriteLine("Жизнь {0} ", args.LiveRand);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < args.LiveRand/2; i++)
            {
                Console.Write("*");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            RoundsCounter++;

        }

        public void OnNextDamage(object sender, DamageToEventArgs args)
        {
            
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.SetCursorPosition(10, 4);
            Console.WriteLine("Урон -{0}", args.DamageValueForUser);
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("Урон -{0}", args.DamageValueForRand);

        }

      
        public void FinishGame(object sender, StartedFinishedGameEventArgs args)
        {
            StopWatch.Stop();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("Результаты игры Duel");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Количество раундов {0}", RoundsCounter);
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

        private int RoundsCounter { get; set; }
        private Stopwatch StopWatch { get; set; }
    }
}
