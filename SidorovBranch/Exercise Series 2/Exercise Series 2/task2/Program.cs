using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Задание 2
             * на ввод поступает длинная строка из случайным образом введённых 
             * русских букв, цифр, пробелов и других символов (кот потанцевал 
             * по клавиатуре). Посчитайте, сколько раз коту удалось ввести слово 
             * кот (Кот, кОт итд).*/

            Console.WriteLine("Введите исследуемую строку со словом \"Кот\":");
            string testStr = Console.ReadLine();

            string[] subString = {
                "Кот", "кОт", "кОТ", "коТ", "КОт", "КОТ", "кот", "КоТ" };

            int count = 0;

            foreach (string s in subString)
            {
                if (testStr.IndexOf(s) != -1)
                {
                    ++count;
                    Console.WriteLine(testStr.IndexOf(s));
                }
            }

            Console.WriteLine("Кот потанцевал {0} раз", count);
            Console.ReadKey();

        }
    }
}
