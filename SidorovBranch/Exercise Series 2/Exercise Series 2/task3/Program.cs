using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задание 3
             * напишите статический метод BigInteger GetNumber(), 
             * который будет запрашивать с клавиатуры число любой 
             * длины (до нажатия Enter) и не будет разрешать вводить 
             * пользователю ничего, кроме цифр и Enter. Подсказка: 
             * используйте посимвольный ввод без немедленного отображения 
             * символа на экран. «неправильно» введенные символы просто должны
             * игнорироваться программой, что и создаст иллюзию «запрета ввода» 
             * этих символов.*/

            Console.WriteLine(GetNumber());
            Console.ReadKey();
        }

        public static BigInteger GetNumber()
        {
            Console.WriteLine("Введите длинное число");
            StringBuilder strNew = new StringBuilder();

            string tempStr = Console.ReadLine();
            foreach(char ch in tempStr)
            {
                if (char.IsNumber(ch))
                    strNew.Append(ch);
            }
            return BigInteger.Parse(strNew.ToString());
        }
    }
}
