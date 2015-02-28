using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_21
{
    class Program
    {
        static void Main(string[] args)
        {

            //Двумерные Рваные массивы. Задание 3

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

            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 2; j < a[i].Length; j++)
                {
                    int sum = a[i][0];
                    for (int k = 2; k <= j; ++k)
                    {
                        sum += a[i][k-1];
                    }
                    a[i][j] = sum;
                }
            }

            Console.Write("\n");

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
