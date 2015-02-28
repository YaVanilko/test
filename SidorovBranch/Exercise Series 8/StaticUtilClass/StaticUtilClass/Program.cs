using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticUtilClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Сделать статический класс Util с методами: Swap (меняет местами 2 
             * входных параметра одного типа), Max(возвращает наибольший из 2 входных 
             * параметров одного типа), Max(возвращает наибольший из 3 входных 
             * параметров одного типа), и аналогичныe Min методы.*/

            List<string> menusList = new List<string>();

            menusList.Add("Min");
            menusList.Add("Max");
            menusList.Add("Swap");
            menusList.Add("Exit");

            bool key = true;
            do
            {
                switch (MenusFunc(menusList) + 1)
                {
                    case 1:
                        // Минимальный из трех елементов
                        Console.WriteLine("\n" + Util.Min(char.Parse(Console.ReadLine()), 
                                                          char.Parse(Console.ReadLine()),
                                                          char.Parse(Console.ReadLine())));
                        break;
                    case 2:
                        // Максимальный из трех елементов
                        Console.WriteLine("\n" + Util.Max(char.Parse(Console.ReadLine()),
                                                          char.Parse(Console.ReadLine()),
                                                          char.Parse(Console.ReadLine())));
                        break;
                    case 3:
                        // Перестановка
                        char firstVar = char.Parse(Console.ReadLine());
                        char secondVar = char.Parse(Console.ReadLine());

                        Console.WriteLine("\n" + firstVar + " " + secondVar);

                        Util.Swap(ref firstVar, ref secondVar);

                        Console.WriteLine("\n" + firstVar + " " + secondVar);

                        break;
                    default:
                        key = !key;
                        break;
                }
            } while (key);

        }

        // Функция печати меню программы: принимает список 
        // пунктов меню и возвращает номер выбранного пункта
        static int MenusFunc(List<string> ListOfPoint)
        {
            for (int i = 0; i < ListOfPoint.Count; ++i)
            {
                Console.WriteLine("[ {0} ] {1}", i + 1, ListOfPoint[i]);
            }
            return int.Parse(Console.ReadLine()) - 1;
        }
    }
}
