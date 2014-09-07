using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_25
{
    class Program
    {
        /*
         * Вывести название дня недели по его номеру 
         * (1 - понедельник, 7 - воскресенье)*/
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Пятница 13");
                    break;
                case 3:
                    Console.WriteLine("Новый Год!");
                    break;
                case 4:
                    Console.WriteLine("Высокосный");
                    break;
                case 5:
                    Console.WriteLine("Июнь");
                    break;
                case 6:
                    Console.WriteLine("Четверг");
                    break;
                default:
                    Console.WriteLine("Выходной");
                    break;
            }
            Console.ReadKey();
        }
    }
}
