using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Существует некий текст со словами и числами. 
             * Нужно подсчитать, сколько в нём слов, и выбросить 
             * из текста каждое третье слово (не считая чисел, которые 
             * должны остаться). Результат вывести на экран, используя 
             * всего одну инструкцию Console.WriteLine.
             * */

            // Тестовая строка
            string str = "00 один 123 два 456 три 789";

            StringBuilder newStr = new StringBuilder();

            int temp = 1;

            string[] strArray = new string[str.Split(' ').Length];

            strArray = str.Split(' ');
            for (int i = 0; i < strArray.Length; ++i)
            {
                if(char.IsDigit(strArray[i][0]))
                    newStr.Append(strArray[i] + " ");
                else if (char.IsLetter(strArray[i][0]) && temp % 3 != 0)
                {
                    newStr.Append(strArray[i] + " ");
                    ++temp;
                }
                else { }
            }
            Console.WriteLine(str);
            Console.WriteLine(newStr);
            Console.ReadKey();

        }
    }
}
