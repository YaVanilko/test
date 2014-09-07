using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task6
{
    /// <summary>
    /// Структура Student инкапсулирует в себя данные о студенте,
    /// содержит свойства ScholarShip, Rating, Hostel,
    /// а также открытые методы ввода и печати данных о студенте
    /// </summary>
    struct Student
    {
        public DateTime DateOfBirthday;
        public DateTime DateOfEntry;

        FullName StudentsName;

        private double scholarShip;
        public double ScholarShip { get { return scholarShip; } }

        private double rating;
        public double Rating { get { return rating; } }

        private char hostel;
        public char Hostel { get { return hostel; } }
        /// <summary>
        /// Метод печати данных о студенте в табличьке с разделителями
        /// </summary>
        public void PrintData()
        {
            Console.Write("| {0,-8}{1,-9}{2,-11}| ", StudentsName.FirstName, 
                StudentsName.LastName, StudentsName.MiddlName);

            Console.Write("{0,-11}",DateOfBirthday.ToShortDateString());

            Console.Write("| {0,-5}| {1,-2}| {2,4} | {3,5} грн. |\n", DateOfEntry.Year, 
                hostel, rating, scholarShip);
        }
        /// <summary>
        /// Метод позволяющий задавать информацию и студенте
        /// </summary>
        public void SetData()
        {
            Console.WriteLine("Введите имя, фамилию и отчество студента");
            StudentsName = new FullName(Console.ReadLine(), 
                Console.ReadLine(), Console.ReadLine());

            Console.WriteLine("Введите дату рождения студента (в текущем формате)");
            DateOfBirthday = DateTime.Parse(Console.ReadLine(), 
                          System.Globalization.CultureInfo.CurrentCulture);

            Console.WriteLine("Введите год поступления студента (в текущем формате)");
            DateOfEntry = DateTime.Parse(Console.ReadLine(),
                          System.Globalization.CultureInfo.CurrentCulture);

            Console.WriteLine("Введите рейтинг студента (0 - 100)");
            rating = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите размер стипендии студента (500 грн. - 1200 грн.)");
            scholarShip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Студент инагородний? (Y / N)");
            hostel = Convert.ToChar(Console.ReadLine());
        }
        /// <summary>
        /// Конструктор, инициализирующий структуру Student
        /// </summary>
        /// <param name="StudentsName">Имя студента</param>
        /// <param name="DateOfEntry">Дата поступления в университет</param>
        /// <param name="DateOfBirthday">Дата рождения</param>
        /// <param name="scholarShip">Стипендия</param>
        /// <param name="rating">Рейтинг студента по Боллонской системе</param>
        /// <param name="hostel">Наличие комнаты в общежитии</param>
        public Student(FullName StudentsName, DateTime DateOfEntry, DateTime DateOfBirthday,
            double scholarShip, double rating, char hostel)
        {
            this.DateOfBirthday = DateOfBirthday;
            this.DateOfEntry = DateOfEntry;
            this.StudentsName = StudentsName;
            this.scholarShip = scholarShip;
            this.rating = rating;
            this.hostel = hostel;
        }
    }
}
