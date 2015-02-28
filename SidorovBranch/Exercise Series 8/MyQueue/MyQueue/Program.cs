using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menusList = new List<string>();
            menusList.Add("Add 'char' element");
            menusList.Add("Get 'char' element");
            menusList.Add("--------------Exit");

            // Создание простой очереди с динамически увеличивающимся размером
            // и параметрическим типом элементов значимого типа
            HomeMadeQueue<char> TestQueue = new HomeMadeQueue<char>();

            bool key = true;
            do
            {
                switch (MenusFunc(menusList) + 1)
                {
                    case 1:
                        // Занесение елемента в очередь
                        TestQueue.Put(char.Parse(Console.ReadLine()));
                        TestQueue.Print();
                        break;
                    case 2:
                        // Извлечение елемента из очереди
                        Console.WriteLine(TestQueue.Get());
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

    // Шаблонный клас реализующий одностор. простую очередь
    // содержащую значимые типы и которая динамически уввеличивает
    // размер при переполнении
    class HomeMadeQueue<T> where T : struct
    {
        // Чсло содержащихся елементов
        private int capacity;
        // Индекс крайнего елемента
        private int endOfIndex;
        // Массив данных произвольного значимого типа
        private T[] InternalData = new T[1];

        // Функция помещения елемента в очередь
        public void Put(T SomeData)
        {
            ++capacity;
            Chek();
            // Если произошло достаточное колличество циклов Put-Get, то 
            // индекс конца может привышать индекс начала
            InternalData[(capacity - 1 + endOfIndex) % InternalData.Length] = SomeData;
        }
        // Функция извлечения елемента типа T
        public T Get()
        {
            --capacity;
            ++endOfIndex;
            Chek();
            return InternalData[(endOfIndex - 1) % InternalData.Length];
        }
        // Приватный метод, который увеличивает динамически размер
        private void Chek()
        {
            if (InternalData.Length < capacity )
            {
                T[] tempArray = new T[InternalData.Length * 2];
                for (int i = 0; i < capacity; ++i)
                {
                    tempArray[i] = InternalData[(endOfIndex + i) % InternalData.Length];
                }
                InternalData = tempArray;
            }

            if (capacity < 0)
                throw new Exception("Atencion! Overflow of Queue...");
        }

        public void Print()
        {
            for (int i = 0; i < capacity; ++i )
                Console.WriteLine(InternalData[(endOfIndex + i) % InternalData.Length]);
            Console.WriteLine(InternalData.Length);
        }
    }

}
