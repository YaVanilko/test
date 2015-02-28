using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace task1
{
    delegate BigInteger FunctionRefer(int N);

    class Program
    {
        static void Main(string[] args)
        {

            /* Задание 1
               Посчитать 200! (циклом или рекурсивной функцией)*/

            Console.WriteLine("Введите целое число для вычисления факториала");
            int N = Convert.ToInt32(Console.ReadLine());

            FunctionRefer[] test = new FunctionRefer[2] { 
                FactorialRecursiv, FactorialIteration };

            foreach (FunctionRefer testDelegate in test)
            {
                DateTime dtStart = DateTime.Now;
                Console.WriteLine("{0}! = {1}", N, testDelegate(N));
                Console.WriteLine("Время вычисления: {0} (МиллиСекунды)",
                    (DateTime.Now - dtStart).TotalMilliseconds.ToString());
            }

            Console.ReadKey();
        }

        public static BigInteger FactorialRecursiv(int N)
        {
            if (N == 0)
                return 1;
            else
                return FactorialRecursiv(N - 1) * N;
        }

        public static BigInteger FactorialIteration(int N)
        {
            BigInteger temp = 1;
            for (int i = 1; i <= N; ++i)
                temp *= i;
            return temp;
        }
    }
}