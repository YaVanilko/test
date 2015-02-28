using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_22
{
    class Program
    {
        static void Main(string[] args)
        {

            //Двумерные Рваные массивы. Задание 4

            Random rand = new Random();

            int[][] a = new int[10][];

            for (int i = 0; i < 10; i++)
            {
                int N = rand.Next(2, 5);
                a[i] = new int[N];
            }
            // заполняем массив случайными числами
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < a[i].Length; j++)
                    a[i][j] = rand.Next(0, 15);
            // выводим массив
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < a[i].Length; j++)
                    Console.Write(" " + a[i][j]);
            }

            Console.Write("\n\n");
            Console.Write("Меняем местами строки одинаковой длинны");

            for (int i = 1; i < 10; i++)
            {
                int temp;
                if (a[i].Length == a[0].Length)
                {
                    // меняем местами строки
                    for (int k = 0; k < a[0].Length; ++k)
                    {
                        temp = a[0][k];
                        a[0][k] = a[i][k];
                        a[i][k] = temp;
                    }
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
