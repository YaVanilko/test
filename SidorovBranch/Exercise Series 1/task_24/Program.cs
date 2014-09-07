using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_24
{
    class Program
    {
        /*
         * 
         * Високосный год
         * Пользователь вводит год. Определить, является ли год високосным по григорианскому 
         * календарю.Год является високосным в двух случаях: либо он кратен 4, но при этом
         * не кратен 100, либо кратен 400. Год не является високосным, если он не кратен 4,
         * либо он кратен 100, но при этом не кратен 400.
         */
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine("Год Высокосный");
            else
                Console.WriteLine("Год НЕ Высокосный");
            Console.ReadKey();
        }
    }
}
