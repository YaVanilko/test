using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Двумерные массивы. Задание 2
            Console.WriteLine("Введите колличество столбцов двумерной матрицы");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество строк двумерной матрицы");
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[M, N];

            Random rand = new Random();

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    a[i, j] = rand.Next(-10, 80);

            for (int i = 0; i < M; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < N; j++)
                    Console.Write(" " + a[i, j]);
            }

            int min, temp = 0;

            for (int i = 0; i < M; i++)
            {
                min = a[i, 0];

                for (int j = 0; j < N; j++)
                    if (a[i, j] <= min)
                    {
                        min = a[i, j];
                        if (min < 0)
                            ++temp;
                    }
            }

            Console.Write("\n");

            if(temp>0)
                Console.WriteLine("Есть отрицательные минимальные елементы в строках");
            else
                Console.WriteLine("Все минимумы положительны");


            Console.ReadKey();
        }
    }
}
