using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Стоимость такси
            Random rand = new Random();

            int timeWay = rand.Next(0, 100);
            Console.WriteLine("Время простоя = " + timeWay + " минут");
            int lenghtWay = rand.Next(0, 300);
            Console.WriteLine("Длинна пути = " + lenghtWay + " киллометров");

            int a = 0;

            if (lenghtWay <= 5)
                a = 20;
            else
                a = (lenghtWay - 5) * 3;

            a += timeWay * 1;

            Console.WriteLine("Сумма = " + a + " грн.");
            Console.ReadKey();
        }
    }
}
