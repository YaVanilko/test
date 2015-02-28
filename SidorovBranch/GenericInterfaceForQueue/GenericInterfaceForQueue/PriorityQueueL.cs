using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericInterfaceForQueue
{
    /// <summary>
    ///Класс реализует Абстрактный тип данных в виде
    ///приорететной очереди. в данной реализации элементы 
    ///выстраиваются в том порядке, в котором пришли, а при 
    ///извлечении происходит поиск по приоритету.
    /// </summary>
    /// <typeparam name="T"> тип элементов помещаемых в очередь</typeparam>
    public class PriorityQueueL<T> : IQueue<T>
    {
        private List<BoxingInCell<T>> listOfElements = new List<BoxingInCell<T>>();

        /// <summary>
        /// элементы выстраиваются в том порядке, в котором пришли
        /// </summary>
        /// <param name="someTypeObj"> Элемент, помещаемый в очередь</param>
        /// <param name="priority"> Приоретет элемента</param>
        public void Put(T someTypeObj, int priority)
        {
            listOfElements.Add(new BoxingInCell<T>(someTypeObj, priority));
 
        }

        public void Put(T someTypeObj)
        {
            this.Put(someTypeObj, -1);

        }
        /// <summary>
        /// при извлечении происходит поиск по приоритету
        /// </summary>
        /// <returns></returns>
        public T Get()
        {
            int tempPriority = -1;
            int firstPriorityIndex = 0;

            for(int i = 0; i< listOfElements.Count; ++i)
            {
                if (listOfElements[i].Priority > tempPriority)
                {
                    tempPriority = listOfElements[i].Priority;
                    firstPriorityIndex = i;
                }
            }

            T temp = listOfElements[firstPriorityIndex].Data;
            listOfElements.RemoveAt(firstPriorityIndex);

            return temp;
        }
        /// <summary>
        /// Удаление элементов с указаным приорететом
        /// </summary>
        /// <param name="priority">приоретет удаляемых элементов</param>
        public void Drop(int priority)
        {
            for (int i = 0; i < listOfElements.Count; ++i)
            {
                if (listOfElements[i].Priority == priority)
                {
                    listOfElements.RemoveAt(i);
                    --i;
                }
            }
    
        }
        /// <summary>
        /// Печать элементов очереди в хранимом порядке
        /// </summary>
        public void Print()
        {
            foreach (BoxingInCell<T> t in listOfElements)
                Console.WriteLine(t.Data);
        }
    }
}
