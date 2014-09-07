using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordsSequenceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем поле игр в котором может содержатся множество отдельных игр
            Game TestGame = new Game();

            // Создаем на поле новую игру
            TestGame.CreateNewGame();

            Console.ReadKey();
        }
    }
}
