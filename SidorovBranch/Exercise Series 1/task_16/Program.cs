using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_16
{
    class Program
    {
        static void Main(string[] args)
        {

            //Двумерные массивы. Задание 1
            Console.WriteLine("Введите колличество столбцов двумерной матрицы");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество строк двумерной матрицы");
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[M,N];

            Random rand = new Random();

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    a[i, j] = rand.Next(10, 99);

            for (int i = 0; i < M; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < N; j++)
                    Console.Write(" " + a[i, j]);
            }

            int I = 0, min = a[I, 0], temp;

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        I = i;
                    }

            for (int j = 0; j < N; j++)
            {
                temp = a[I, j];
                a[I, j] = a[M - 1, j];
                a[M - 1, j] = temp;
            }

            Console.Write("\n");

            for (int i = 0; i < M; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < N; j++)
                    Console.Write(" " + a[i, j]);
            }

            Console.ReadKey();
        }
    }
}
