using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Среднее арифметическое 5 чисел
            int[] a = new int[5];
            for (int i = 0; i < 5; ++i)
                a[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Среднее = " + a.Sum()/a.Length);
            Console.ReadKey();
        }
    }
}
