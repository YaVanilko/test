using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Двумерные Рваные массивы. Задание 1

            Random rand = new Random();

            

            int[][] a = new int[10][];

            for (int i = 0; i < 10; i++)
            {
                int N = rand.Next(2, 7);
                a[i] = new int[N];
            }

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < a[i].Length; j++)
                    a[i][j] = rand.Next(0, 15);

            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < a[i].Length; j++)
                    Console.Write(" " + a[i][j]);
            }

            Console.ReadKey();
        }
    }
}
