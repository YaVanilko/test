using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task_26
{
    class Program

        /*
         * Температура С в градусах Цельсия изменяется от 0 до 100 с шагом 5. 
         * Напечатать таблицу перевода температуры из градусов Цельсия в градусы
         * Фаренгейта (F). Формула перевода: F = 1,8 C + 32
         * */
    {
        static void Main(string[] args)
        {
            for (int Celcium = 0; Celcium <= 100; ++Celcium)
                Console.WriteLine(1.8 * Celcium + 32 + "(F)");
            Console.ReadKey();
        }
    }
}
