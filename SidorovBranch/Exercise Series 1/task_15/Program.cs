using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //калькулятор Swich массивы
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 12, 3 };
            int[] b = { 50, 5, 3, 12, 8, 7, 2, 4, 1 };
            char[] operation = { '+', '-', '-', '*', '*', '-', '%', '+', '/' };
            int[] res = new int[a.Length];
            for (int i = 0; i < a.Length; ++i)
                switch (operation[i])
                {
                    case '+':
                        res[i] = a[i] + b[i];
                        break;
                    case '-':
                        res[i] = a[i] - b[i];
                        break;
                    case '/':
                        res[i] = a[i] / b[i];
                        break;
                    case '*':
                        res[i] = a[i] * b[i];
                        break;
                    case '%':
                        res[i] = a[i] % b[i];
                        break;
                }
            foreach (int itg in res)
                Console.WriteLine("Результат: " + itg);

            Console.ReadKey();
        }
    }
}
