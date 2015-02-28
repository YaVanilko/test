using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Посчитать сумму цифр во введенном пользователем 4-хзначном целом числе. 
             * Вывести все эти цифры на экран, каждую цифру в отдельной строке, и 
             * пятой строкой их сумму.
             */


            const int n = 4;

            int dec = (int) Math.Pow(10, n-1);

            int rangeMax = dec * 10 - 1;
            int rangeMin = dec;

            // генерируем случайное число в заданом диапазоне
            int testNumber = new Random().Next(rangeMin, rangeMax);

            Console.WriteLine("Число = " + testNumber);

            int sum = 0;

            for (int i = 0; i < n; ++i)
            {
                sum += testNumber / dec;
                Console.WriteLine(testNumber / dec);
                testNumber = testNumber % dec;
                dec /= 10;
            }
            Console.WriteLine("Сумма цифр числа = " + sum);
            Console.ReadKey();
        }
    }
}
