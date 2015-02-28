using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Существует массив строк формата: "07.07.2014 10:00-13:25,14:30-17:00" (можно задать 
             * его прямо в программе, напишите не меньше 10 строк)При этом дата в каждой строке 
             * только одна, отделяется пробелом, а числа представляют собой диапазоны времени 
             * (промежутки рабочего времени). Предполагается, что внутри одной строки временные
             * значения всегда должны возрастать слева направо. Пользователь задаёт диапазон дат, 
             * вводит с клавиатуры.Подсчитать общее количество рабочего времени в этом диапазоне, 
             * с точностью до минут (не округляя вверх), основываясь на данных из массива строк.
             * */

            string[] strArray = {"07.07.2013 10:00-13:25", 
                                 "08.07.2013 10:00-13:25,14:30-17:00",
                                 "07.07.2014 10:00-13:25", 
                                 "08.07.2014 10:00-13:25,14:30-17:00", 
                                 "09.07.2014 14:30-17:00", 
                                 "10.07.2014 10:00-13:25,14:30-17:00", 
                                 "07.08.2014 10:00-13:25", 
                                 "08.08.2014 10:00-13:25,14:30-17:00,18:30-19:53:41", 
                                 "09.08.2014 14:30-17:00", 
                                 "10.08.2014 10:00-13:25,14:30-17:00"};

            DateTime Data1, Data2;
            TimeSpan Frame = new TimeSpan();

            for (int i = 0; i < strArray.Length; ++i)
            {
                string[] str = strArray[i].Split(' ');
                string[] subStr = str[1].Split(',');
                for (int j = 0; j < subStr.Length; ++j)
                {
                    string[] subSubStr = subStr[j].Split('-');

                    Data1 = DateTime.Parse(str[0] + " " + subSubStr[0],
                        System.Globalization.CultureInfo.InvariantCulture);

                    Data2 = DateTime.Parse(str[0] + " " + subSubStr[1],
                          System.Globalization.CultureInfo.InvariantCulture);

                    Frame += Data2 - Data1;

                    Console.WriteLine("c " + Data1.ToString() + " по " + Data2.ToString() + " и");
                }
            }

            Console.WriteLine("Сумма времени: {0}", Frame.ToString());
            Console.ReadKey();
        }
    }
}
