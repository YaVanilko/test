using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task6
{
    /// <summary>
    /// Структура FullName хранит в себе полное имя
    /// </summary>
    struct FullName
    {
        string firstName;
        string lastName;
        string middlName;
        /// <summary>
        /// Конструктор, инициализирующий структуру Name
        /// </summary>
        /// <param name="firstName"> Имя студента</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="middlName">Отчество</param>
        public FullName(string firstName, string lastName, string middlName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.middlName = middlName;
        }

        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string MiddlName { get { return middlName; } }
    }
}
