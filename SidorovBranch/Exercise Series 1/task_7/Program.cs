using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Игра в кости
            Random rand = new Random();

            int kredit = rand.Next(10, 100);
            Console.WriteLine("Кредит = " + kredit + " грн.");

            int k1 = rand.Next(1, 12);
            Console.WriteLine("кость 1 = " + k1);

            int k2 = rand.Next(1, 12);
            Console.WriteLine("кость 2 = " + k2);

            int a = 0;

            if (k1 % 3 == 0 && k2 % 5 == 0)
                a = kredit * 5;
            else if (k1 % 2 == 0 && k2 % 2 == 0)
                a = kredit * 2;
            else if (k1 == 12 || k2 == 12)
                a = kredit * 10;
            else if (k1 == 12 && k2 == 1 || k1 == 6 && k2 == 6)
                a = kredit * 50;
            else
                Console.WriteLine("Вы проиграли");

            Console.WriteLine("Сумма выиграша = " + a + " грн.");
            Console.ReadKey();
        }
    }
}
