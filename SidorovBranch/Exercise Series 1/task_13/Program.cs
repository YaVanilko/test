using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {

            //калькулятор Swich
            Random rand = new Random();

            int res = 0;

            int a = rand.Next(1, 10);
            int b = rand.Next(1, 10);

            Console.WriteLine("что будем делать: {0} ? {1} ( +, -, /, *, )", a, b);

            char operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                case '/':
                    res = a / b;
                    break;
                case '*':
                    res = a * b;
                    break;
            }

            Console.WriteLine("Результат: " + res);

            Console.ReadKey();
        }
    }
}
