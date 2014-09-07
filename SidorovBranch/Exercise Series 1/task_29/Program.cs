using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_29
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Одноклеточная амеба каждые 3 часа делится на 2 клетки. 
             * Определить, сколько амеб будет через 3, 6, 9, 12,..., 24 часа.
             * */

            const int time = 3;
            int bacteriumCount = 1;
            const int horsesInDay = 24;

            for (int i = time; i <= horsesInDay; i += time)
            {
                bacteriumCount *= 2;
                Console.WriteLine(bacteriumCount + "бактерий");
            }

            Console.ReadKey();
        }
    }
}
