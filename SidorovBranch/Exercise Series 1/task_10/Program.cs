using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //бегун бегает
            int i = 0;
            double temp = 10;
            double sum = 0;
            while (i <= 7)
            {
                temp += 0.1 * temp;
                sum += temp;
                ++i;
            }
            Console.WriteLine("на 7 день пробежит {0} км", sum);

            i = 0;
            temp = 10;
            

            while (true)
            {
                ++i;
                temp += 0.1 * temp;
                if (temp >= 15)
                    break;
            }
            Console.WriteLine("на {0} станет бегать по более 15 км", i);

            i = 0;
            temp = 10;
            sum = 0;

            while (true)
            {
                ++i;
                temp += 0.1 * temp;
                sum += temp;
                if (sum >= 50)
                    break;
            }
            Console.WriteLine("на {0} день суммарно пробежит более 50 км", i);

            Console.ReadKey();
        }
    }
}
