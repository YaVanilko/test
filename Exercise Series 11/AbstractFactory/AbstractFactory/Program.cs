using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menusList = new List<string>();
            menusList.Add("-Add new car");
            menusList.Add("---Get drive");
            menusList.Add("--------Exit");

            List<string> subMenusList = new List<string>();
            subMenusList.Add("---BMW car");
            subMenusList.Add("---Zaz car");

            List<string> subSubMenusList = new List<string>();
            subSubMenusList.Add("Изменить скорость");
            subSubMenusList.Add("Изменить направление");
            subSubMenusList.Add("Переключить Фары");
            subSubMenusList.Add("Показания приборов");

            List<AbstractCar> CarsList = new List<AbstractCar>();

            bool exitCondition = true;

            ZazFactory zaz = new ZazFactory();
            BMWFactory bmw = new BMWFactory();

            CarsList.Add(zaz.CreateCar("Lanos"));
            CarsList.Add(bmw.CreateCar("-X5-"));


            do
            {
                try
                {
                    switch (MenusFunc(menusList))
                    {
                        case 1:
                            Console.WriteLine("Чей автомобиль хотите создать? (de / ua)");
                            if (MenusFunc(subMenusList) == 1)
                            {
                                Console.WriteLine("Введите модель авто:");
                                CarsList.Add(bmw.CreateCar(Console.ReadLine()));
                            }
                            else
                            {
                                Console.WriteLine("Введите модель авто:");
                                CarsList.Add(zaz.CreateCar(Console.ReadLine()));
                            }
                            break;

                        case 2:
                            Console.WriteLine("На каком авто будем кататься?");
                            AbstractCar ChosenCar = CarsList[MenusFunc(
                                CarsList.Select(x => x.model).ToList<string>()) - 1];
                            do
                            {
                                switch (MenusFunc(subSubMenusList))
                                {
                                    case 1: ChosenCar.Speed += int.Parse(Console.ReadLine());
                                        break;
                                    case 2: ChosenCar.Direction += int.Parse(Console.ReadLine());
                                        break;
                                    case 3: ChosenCar.Light = !ChosenCar.Light;
                                        break;
                                    case 4:
                                        Console.WriteLine("Скорость {0}", ChosenCar.Speed);
                                        Console.WriteLine("Направление {0}", ChosenCar.Direction);
                                        Console.WriteLine("Фары {0}", ChosenCar.Light);
                                        break;
                                    default:
                                        break;
                                }

                            } while (ChosenCar.Speed > 0);
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
            for (int i = 0; i < ListOfPoint.Count; ++i)
            {
                Console.WriteLine("[{0}] {1}", i + 1, ListOfPoint[i]);
            }
            return int.Parse(Console.ReadLine());
        }
    }
}
