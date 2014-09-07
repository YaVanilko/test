using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Дано натуральное число. Выяснить, 
             * является ли оно простым, т.е. делится 
             * только на 1 и на само себя. */

            Console.WriteLine("Проверим на простоту число: ");
            int nat = Convert.ToInt32(Console.ReadLine());

            bool key = true;

            for (int i = 2; i < nat; ++i)
            {
                if (i != nat && nat % i == 0)
                {
                    Console.WriteLine("число не простое");
                    key = !key;
                    break;
                }
            }
            if (key)
                Console.WriteLine("число простое");
            Console.ReadKey();
        }
    }
}
