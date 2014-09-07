using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Посчитайте средний возраст поступления среди студентов, с точностью до
             * месяца. 
             * 
             * Первый из списка студентов летит в Париж, парижское время прилёта – 
             * завтра в 10 утра. Нужно подсчитать, исполнится ли ему уже на 
             * это время полных 25 лет.
             * */
            const int number = 6;

            // Создание массива из шести студентов
            Student[] NewStudent = new Student[number];
            
            // Заготовка данных о студентах: имена, даты, рейтинг, стипендия, общага
            int[] ratingArray = {50, 60, 75, 80, 95, 100};
            int[] scholarShipArray = {0, 0, 0, 500, 700, 1200};

            char[] hostelArray = {'Y', 'N', 'N', 'Y', 'N', 'Y'};

            string[,] Name = {{"Вася", "Пупкин", "Иванович"}, {"Петя", "Ковалеко", "Владимирович"},
                             { "Вова", "Нестеров", "Васильевч"}, {"Женя", "Петров", "Игоревич"}, 
                             { "Витя", "Антонеко", "Валериевч"}, {"Саша", "Иванов", "Антонович"}};

            string[] stringData = { "22.11.1989", "28.08.1982", "17.03.1926", 
                                    "08.08.1988", "19.08.1989", "12.10.1975"};

            string[] entryData = { "12.11.2011", "19.08.2002", "08.02.2003", 
                                  "17.01.2006", "28.06.2005", "17.01.2004"};

            // Инициализация массива студентами
            for (int i = 0; i < number; ++i)
            {
                NewStudent[i] = new Student(
                    new FullName(Name[i, 0], Name[i, 1], Name[i, 2]),
                    DateTime.Parse(entryData[i]),
                    DateTime.Parse(stringData[i]),
                    scholarShipArray[i],
                    ratingArray[i],
                    hostelArray[i]);
            }

            // Печать таблички на консоль PrintData
            foreach (Student std in NewStudent)
                std.PrintData();

            TimeSpan Frame = new TimeSpan();

            Console.WriteLine("\nСредний Возраст поступивших студентов");
            for (int i = 0; i < NewStudent.Length; ++i )
                Frame += NewStudent[i].DateOfEntry - NewStudent[i].DateOfBirthday;

            Console.WriteLine(Frame.Days / 365 / NewStudent.Length + 
                " лет и " + Frame.Days / NewStudent.Length % 365 / 30 + " месяцоф");

            // обнуляем буферную переменную
            Frame -= Frame;

            DateTime arriveTime = new DateTime(DateTime.UtcNow.Year, 
                                               DateTime.UtcNow.Month, 
                                               // прибытие завтра, т.е. +1 день
                                               DateTime.UtcNow.Day + 1, 
                                               // Париж в поясе "+1"
                                               10 + 1, 
                                               0, 
                                               0);

            DateTime birthdayTime = new DateTime(NewStudent[0].DateOfBirthday.Year + 25,
                                                 NewStudent[0].DateOfBirthday.Month,
                                                 NewStudent[0].DateOfBirthday.Day,
                                                 NewStudent[0].DateOfBirthday.Hour,
                                                 NewStudent[0].DateOfBirthday.Minute,
                                                 NewStudent[0].DateOfBirthday.Second);

            Frame = arriveTime - birthdayTime;

            if (Frame.TotalMinutes >= 0)
                Console.WriteLine("\nИсполнится 25 лет 1-ому студенту");
            else
                Console.WriteLine("\nНЕ сполнится 25 лет 1-ому студенту");

            Console.ReadKey();
        }
    }
}
