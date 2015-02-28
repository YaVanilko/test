using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, min = int.MinValue;
            while (true)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                    Console.WriteLine(min);
                }
                if (number == 0)
                    break;
                
            }
        }
    }
}
