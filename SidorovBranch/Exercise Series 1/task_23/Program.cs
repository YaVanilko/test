using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_23
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Чётные числа
             * Определить, что среди заданных целых чисел 
             * A, B, C, D есть хотя бы два чётных. */

            int[] arrayTest = { 5, 6, 9, 8};
            int temp = 0;
            for (int i = 0; i < arrayTest.Length; ++i)
                if (arrayTest[i] % 2 == 0)
                    ++temp;
            if (temp >= 2)
                Console.WriteLine("Четных чисел больше/равно двух");
            Console.ReadKey();
        }
    }
}
