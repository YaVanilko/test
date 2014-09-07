using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_18
{
    class Program
    {
        static void Main(string[] args)
        {

            //Двумерные массивы. Задание 3
            Console.WriteLine("Введите размер квадратной матрицы");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[N, N];

            Random rand = new Random();

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    a[i, j] = rand.Next(-5, 80);

            for (int i = 0; i < N; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < N; j++)
                    Console.Write(" " + a[i, j]);
            }

            int average = 0;

            for (int i = 0; i < N; ++i)
                average += a[i, i];

            average /= N;

            for (int i = 0; i < N; i++)
                for (int j = 0; j < i; j++)
                {
                    if (a[i, j] > 0)
                        a[i, j] = average;
                }

            Console.Write("\n");

            for (int i = 0; i < N; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < N; j++)
                    Console.Write(" " + a[i, j]);
            }

            Console.ReadKey();
        }
    }
}
