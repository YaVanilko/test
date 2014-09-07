using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {

            //вывод простых числлел
            Random rand = new Random();

            int nat = rand.Next(1, 100);
            Console.WriteLine("число: " + nat);

            int temp;

            for (int k = 1; k <= nat; k++)
            {
                temp = 1;
                for (int i = 2; i < nat; ++i)
                {
                    if (i != k && k % i == 0)
                    {
                        temp = 0;
                        break;
                    }        
                }
                if(temp == 1)
                    Console.WriteLine(k);
            }

            Console.ReadKey();
        }
    }
}
