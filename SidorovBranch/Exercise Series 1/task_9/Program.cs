using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* В первый день пловец проплыл 3 км. В каждый следующий день 
             * он проплывал на 10% больше, чем в предыдущий.
             * а) В какой по счету день пловец начнет проплывать более 5 км?
             * б) К какому дню он суммарно проплывет более 30 км */

            int i = 0;
            double temp = 3; // 3 км

            do
            {
                ++i;
                temp += 0.3 * temp;
            } while (temp < 5);

            Console.WriteLine("на {0} день проплывет более 5 км", i);

            i = 0;
            temp = 3;
            double sum = 0;

            do
            {
                ++i;
                temp += 0.3 * temp;
                sum += temp;
            } while (sum < 30);

            Console.WriteLine("на {0} день суммарно проплывет более 30 км", i);
            Console.ReadKey();
        }
    }
}
