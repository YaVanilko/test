using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // среднее случайных чисел
            Random rand = new Random();
            int [] a = new int[1000];
            for (int i = 0; i < 1000; ++i)
                a[i] = rand.Next(1, 100);

            Console.WriteLine("Среднее = " + a.Sum() / a.Length);
            Console.ReadKey();
        }
    }
}
