using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // стороны треугольника

            /* Треугольник задан тремя сторонами. Пользователь НЕ знает,
             * какие конкретно стороны являются катетами и гипотенузой.
             * Сообщить пользователю, является ли этот треугольник прямоугольным.
             * Погрешность вычисления 0.01 вычисление квадратного корня: Math.Sqrt */

            const int n = 3;
            const double range = 0.01;

            double[] a = new double[n];

            for (int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine("Введите сторону треугольника");
                a[i] = Convert.ToDouble(Console.ReadLine());
                a[i] *= a[i];
            }

            double difference = Math.Abs(a.Sum() - 2 * a.Max());

            if (difference <= range)
                Console.WriteLine("Прямоугольный" + a.Max());
            else
                Console.WriteLine("Не пряпоугольный" + a.Max());

            Console.ReadKey();
        }
    }
}
