using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordsSequenceGame
{
    public delegate string DialogInterface(string str);
    /// <summary>
    /// Класс поля множества игор
    /// </summary>
    class Game
    {
        /// <summary>
        /// Список игр на поле
        /// </summary>
        static List<UnitGame> ListOfNewGames;
        /// <summary>
        /// Ссилка на ф-цию ввода-вывода
        /// </summary>
        DialogInterface delg = UserInterfase;
        /// <summary>
        /// В конструкторе создается список игр
        /// </summary>
        public Game()
        {
            ListOfNewGames = new List<UnitGame>();
        }
        /// <summary>
        /// Функция, отвечающая за создание и запуск новой игры
        /// </summary>
        public void CreateNewGame()
        {
            int keySwitch;

            while (true)
            {
                try
                {
                    keySwitch = int.Parse(delg("[1] Help \n[2] Play \n[3] Exit"));

                    if (keySwitch == 2)
                        /// ===================================================================
                        /// Важно!!! Здесь Должны лежать все словари!!!! c:\tmp\dictionares\...
                        /// ===================================================================
                        ListOfNewGames.Add(new UnitGame(delg));
                    else if (keySwitch == 3)
                        break;
                    else
                    {
                        GetHelp();
                    }
                }
                catch
                {
                    delg("Wrong string format!... Try again...");
                }
            }
        }
        /// <summary>
        /// Функция ввода-вывода
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UserInterfase(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
        /// <summary>
        /// Функция вывода справки
        /// </summary>
        public void GetHelp()
        {
            delg("No rules – No boredom :) ...");
        }
    }
}
