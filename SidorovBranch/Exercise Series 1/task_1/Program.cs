using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // квадраты натуральных чисел

            /* Выведите все точные квадраты натуральных чисел, которые (квадраты) 
             * меньше заданного числа N. (натуральные - это числа, которые мы используем 
             * при счёте: 1, 2, 3 и т.д.) Например, если задано число 15, то результат 
             * должен быть 1, 4, 9 */

            Console.WriteLine("Введите границу квадратов натуральных чисел: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int sqrtN = (int)Math.Sqrt(N);

            for (int i = 1; i <= sqrtN; ++i)
            {
                Console.WriteLine(i * i);
            }
            Console.ReadKey();
        }
    }
}
