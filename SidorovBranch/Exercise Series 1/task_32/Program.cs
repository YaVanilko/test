using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_32
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Вывести на экран 20 элементов последовательности 
             * 1, 4, 7, 10, 13… 
             * с использованием цикла while(true) {}
             * */
            int temp = 1;
            int step = 3;
            int iteration = 0;
            int limit = 20;
            while (true) 
            {
                ++iteration;
                Console.WriteLine(temp);
                temp += step;
                if (iteration == limit)
                    break;
            }
            Console.ReadKey();
        }
    }
}
