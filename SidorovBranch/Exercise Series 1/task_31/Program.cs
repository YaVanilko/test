using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Напишите программу, которая будет «спрашивать» правильный 
             * пароль, до тех пор, пока он не будет введен. Правильный 
             * пароль пусть будет «root». Если пароль не верный, программа 
             * должна сказать "Неверный пароль!"*/


            string str;
            string passWord = "abcd";
            while (true)
            {
                Console.WriteLine("Введите пароль: (abcd)");
                str = Console.ReadLine();
                if (String.Equals(str, passWord))
                    break;
                else
                    Console.WriteLine("Пароль не верен");
            }
            Console.WriteLine("Правильно");
            Console.ReadKey();
        }
    }
}
