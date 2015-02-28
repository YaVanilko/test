using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericInterfaceForQueue
{
    class HomeMadeQueue<T> where T : struct, IQueueNonPriority<T>
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
            if (InternalData.Length < capacity)
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
            for (int i = 0; i < capacity; ++i)
                Console.WriteLine(InternalData[(endOfIndex + i) % InternalData.Length]);
            Console.WriteLine(InternalData.Length);
        }
    }
}
