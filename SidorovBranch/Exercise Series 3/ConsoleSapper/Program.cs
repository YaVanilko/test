using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSapper
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Класс Field должен инкапсулировать всю работу с игровым полем и предоставлять 
             * возможность работать с полем на логическом уровне. Работа с консолью внутри 
             * класса допускается только в методе Print (исключительно для простоты вывода 
             * поля на экран).*/

            Console.WriteLine("Введите размер поля: (1 - 10)");
            try
            {
                Field MyField = new Field(
                    Convert.ToInt32(Console.ReadLine()),
                    Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Введите колличество минн: ");
                if (!MyField.SetBombsAtField(Convert.ToInt32(Console.ReadLine())))
                    Console.WriteLine("Ошибка!...");
                do
                {
                    try
                    {
                        Console.WriteLine("Введите координаты мины по высоте ");
                        int x = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите координаты мины по ширине ");
                        int y = Convert.ToInt32(Console.ReadLine());

                        // проверка желания покинуть игру
                        if (x == 0 && y == 0) break;

                        // проверка подрыва на мине
                        if (MyField.IsBombsAt(x, y))
                        {
                            Console.WriteLine("\n Доигрались :-) ");
                            break;
                        }
                        if (MyField.IsWinCondition())
                        {
                            Console.WriteLine("\n Вы выиграли !!!!! ");
                            break;
                        }
                        Console.Clear();
                        MyField.PrintField();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ошибка! Вводите правильные координаты поля! \n{0}", e.ToString());
                    }
                } while (true);

                MyField.PrintField();
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Ошибка! Размер не может быть < 0 \n{0}", e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка! Не вводите символы \n{0}", e.ToString());
            }
            Console.ReadKey();
        }
    }
}
