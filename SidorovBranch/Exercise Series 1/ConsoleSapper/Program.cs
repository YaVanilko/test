using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер поля: (1 - 10)");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите колличество минн: ({0} - {1})", 
                0, size*size-1);

            int number = Convert.ToInt32(Console.ReadLine());

            // формируем минное поле с "бортиком" в одну позицию
            int[,] field = new int[size + 2, size + 2];

            // массив координат мин
            int[,] coord = new int[2, number];

            Random rand = new Random();

            // формируем список уникальных адресов (порядкового
            // номера) мин
            List<int> numList = new List<int>();
            for (int i = 1; i <= size * size; ++i)
                numList.Add(i);

            // даем случайный адрес каждому номеру мины
            int temp;
            for (int i = 0; i < number; ++i)
            {
                temp = rand.Next(0, numList.Count - 1);
                coord[0, i] = 1 + numList[temp] -  (numList[temp] / size) * size;
                coord[1, i] = 1 + numList[temp] / size;
                numList.RemoveAt(temp);
            }

            // заполняем позиции мин единицами
            for (int i = 0; i < number; ++i)
                field[coord[0, i], coord[1, i]] = 1;

            // массив символов соответствует интерфейсу
            // и скрывает положение мин, а также отображает
            // открытые поля
            char[,] ChField = new char[size, size];
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    ChField[i, j] = '?';

            for (int i = 0; i < size; ++i)
            {
                Console.Write('\n');
                for (int j = 0; j < size; ++j)
                    Console.Write(" " + ChField[i, j]);
            }

            int coord_x = 0, coord_y = 0;
            int sum;
            int key = 1;

            while (key != 0)
            {
                sum = 0;

                Console.WriteLine("\n Введите координаты мины по высоте (1 - {0}): ", size);
                coord_x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n Введите координаты мины по ширине (1 - {0}): ", size);
                coord_y = Convert.ToInt32(Console.ReadLine());

                // проверка желания покинуть игру
                if (coord_x == 0 && coord_y == 0 || coord_x > size && coord_y > size)
                    break;

                // проверка подрыва на мине
                for (int i = 0; i < number; ++i)
                    if (coord_x == coord[0, i] && coord_y == coord[1, i])
                        key = 0;

                // подщет колличества мин вокруг введеннойй позиции
                for (int i = coord_x - 1; i < coord_x + 2; ++i)
                    for (int j = coord_y - 1; j < coord_y + 2; ++j)
                        sum += field[i, j];

                // открытие полей
                if (sum == 0)
                    ChField[coord_x - 1, coord_y - 1] = '_';
                else if (sum != 0 && key != 0)
                    ChField[coord_x - 1, coord_y - 1] = Convert.ToChar(sum.ToString());
                else if (key == 0)
                    break;

                for (int i = 0; i < size; ++i)
                {
                    Console.Write('\n');
                    for (int j = 0; j < size; ++j)
                        Console.Write(" " + ChField[i, j]);
                }
            }

            // вывод реального положения мин
            for (int i = 1; i <= size; ++i)
            {
                Console.Write('\n');
                for (int j = 1; j <= size; ++j)
                {
                    if (field[i, j] == 1)
                        Console.Write(" M");
                    else
                        Console.Write(" _");
                }
            }

            Console.WriteLine("\n Доигрались :-) ");
            Console.ReadKey();
        }
    }
}
