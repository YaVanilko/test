using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericInterfaceForQueue
{
    /// <summary>
    /// Вспомогательный клас, позволяющий хранить елементы вместе с 
    /// приоритетом. Инкапсулирует элемент и его приоритет
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class BoxingInCell<T>
    {
        public T Data { get; private set; }
        public int Priority { get; private set; }

        public BoxingInCell(T data, int priority)
        {
            Data = data;
            Priority = priority;
        }
    }
}
