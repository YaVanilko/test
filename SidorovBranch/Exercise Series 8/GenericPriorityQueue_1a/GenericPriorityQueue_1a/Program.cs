using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericPriorityQueue_1a
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Сделать класс PriorityQueue, который может работать с любыми типами данных.
             * Методы класса:
             * Put(/данные/, /приоритет (только 3 варианта: высокий, средний или низкий)/)
             * Get() /извлекает первый наиболее приоритетный элемент из очереди/
             * Drop(/приоритет/) /удаляет из очереди, не используя, все элементы с указанным приоритетом/
             * При выполнении этого задания можно пользоваться коллекциями.*/

            List<string> menusList = new List<string>();

            menusList.Add("--Add 'char' element");
            menusList.Add("--Get 'char' element");
            menusList.Add("-Drop 'char' element");
            menusList.Add("----------------Exit");

            // Создание простой очереди с динамически увеличивающимся размером
            // и параметрическим типом элементов значимого типа
            PriorityQueue<char> TestQueue = new PriorityQueue<char>();

            TestQueue.Put('a', 1);
            TestQueue.Put('z', -1);
            TestQueue.Put('c', 1);
            TestQueue.Put('x', -1);
            TestQueue.Put('f', 0);
            TestQueue.Put('w', -1);
            TestQueue.Put('d', 0);
            TestQueue.Put('b', 1);
            TestQueue.Put('g', 0);

            bool key = true;
            do
            {
                switch (MenusFunc(menusList) + 1)
                {
                    case 1:
                        // Занесение елемента в очередь
                        TestQueue.Put(char.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        // Извлечение елемента из очереди
                        Console.WriteLine(TestQueue.Get() + "\n");
                        TestQueue.Print();
                        break;
                    case 3:
                        // Извлечение елемента из очереди
                        TestQueue.Drop(int.Parse(Console.ReadLine()));
                        TestQueue.Print();
                        break;
                    default:
                        key = !key;
                        break;
                }
            } while (key);
        }

        // Функция печати меню программы: принимает список 
        // пунктов меню и возвращает номер выбранного пункта
        static int MenusFunc(List<string> ListOfPoint)
        {
            for (int i = 0; i < ListOfPoint.Count; ++i)
            {
                Console.WriteLine("[ {0} ] {1}", i + 1, ListOfPoint[i]);
            }
            return int.Parse(Console.ReadLine()) - 1;
        }
    }
}
