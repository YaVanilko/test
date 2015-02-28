using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Вы организатор лотереи. Пользователь вводит ставку. Вы бросаете 
             * 12-гранный кубик. Если выпадают значения от 1 до 5, пользователь 
             * проиграл. Если выпадают значения от 6 до 8, пользователь получает 
             * свою ставку обратно. Если выпало от 9 до 11, пользователь получает 
             * двойную ставку, а если выпало 12 - ставку умноженную на 10.
             * После окончания игры покажите пользователю, сколько он выиграл. */

            Random rand = new Random();
            Console.WriteLine("Введите Вашу ставку: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int nat = rand.Next(1, 12);

            Console.WriteLine("выпало число: " + nat);

            switch (nat)
            {
                case 1: case 2: case 3: case 4: case 5:
                      Console.WriteLine("Вы проиграли");
                    break;
                case 6: case 7:case 8: 
                    Console.WriteLine("Вы получаете " + number);
                    break;
                case 9: case 10: case 11:
                    Console.WriteLine("Вы получаете " + number*2);
                    break;
                case 12:
                    Console.WriteLine("Вы получаете " + number*10);
                    break;
            }

            Console.ReadKey();
        }
    }
}
