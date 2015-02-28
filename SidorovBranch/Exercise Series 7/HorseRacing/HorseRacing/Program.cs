using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HorseRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menusList = new List<string>();
            menusList.Add("-------------------------Add subscriber");
            menusList.Add("------------Sign an existing subscriber");
            menusList.Add("------------------------------Add horse");
            menusList.Add("Inform subscribers about what horse won");
            menusList.Add("-----------------------------------Exit");

            List<Subscriber> Player = new List<Subscriber>();
            List<Horse> RuningHorse = new List<Horse>();
            bool exitCondition = true;

            Player.Add(new Subscriber("Игрок - №1"));
            Player.Add(new Subscriber("Игрок - №2"));

            RuningHorse.Add(new Horse("Кося №1"));
            RuningHorse.Add(new Horse("Кося №2"));
            RuningHorse.Add(new Horse("Кося №3"));

            do
            {
                try
                {
                    switch (MenusFunc(menusList) + 1)
                    {
                        case 1:
                            Console.WriteLine("Введите имя подписчика:");
                            Player.Add(new Subscriber(Console.ReadLine()));
                            Console.WriteLine("Можно подписаться на победу следующих лошадей:");
                            // использование лямбда-выражения
                            RuningHorse[MenusFunc(
                                RuningHorse.Select(x => x.Name).ToList<string>())].WhoWins +=
                                new WinnerMessage(Player[Player.Count - 1].handler);
                            break;

                        case 2:
                            int playerNumber = MenusFunc(Player.Select(x => x.Name).ToList<string>());
                            RuningHorse[MenusFunc(
                                RuningHorse.Select(x => x.Name).ToList<string>())].WhoWins +=
                                new WinnerMessage(Player[playerNumber].handler);
                            break;

                        case 3:
                            Console.WriteLine("Введите имя конячьки");
                            RuningHorse.Add(new Horse(Console.ReadLine()));
                            break;

                        case 4:
                            RuningHorse[WinnersNumber(RuningHorse)].IsWinner();
                            break;

                        default:
                            exitCondition = !exitCondition;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Проверте формат вводимой строки!...");
                }
            } while (exitCondition);
        }

        static int MenusFunc(List<string> ListOfPoint)
        {
            Console.Clear();

            for (int i = 0; i < ListOfPoint.Count; ++i)
            {
                Console.WriteLine("[ {0} ] {1}", i + 1, ListOfPoint[i]);
            }
            return int.Parse(Console.ReadLine()) - 1;
        }

        static int WinnersNumber(List<Horse> horses)
        {
            return new Random().Next(0, horses.Count);
        }
    }
}
