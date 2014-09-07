using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericInterfaceForQueue
{
    /// <summary>
    ///Класс реализует Абстрактный тип данных в виде
    ///приорететной очереди. Сортировка елементов осуществляется
    ///путем вставки елемента в список согласно приоретету
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class PriorityQueueH<T> : IQueue<T>
    {
        private List<T> listOfElements = new List<T>();

        private int middlPriority;
        private int maxPriority;
        /// <summary>
        /// элементы сразу должны выстраиваться в том порядке, 
        /// в котором их будут забирать, а забирать уже легко;
        /// </summary>
        /// <param name="someTypeObj"> Элемент, помещаемый в очередь</param>
        /// <param name="priority"> Приоретет элемента</param>
        public void Put(T someTypeObj, int priority)
        {
            if(priority <= -1)
            {
                listOfElements.Add( someTypeObj);
            }

            else if (priority >= 1)
            {
                listOfElements.Insert(maxPriority, someTypeObj);
                ++maxPriority;
                ++middlPriority;
            }

            else
            {
                listOfElements.Insert(middlPriority, someTypeObj);
                ++middlPriority;
            }
        }

        public void Put(T someTypeObj)
        {
            this.Put(someTypeObj, -1);
        }
        /// <summary>
        /// Возвращает первый приорететный элемент
        /// </summary>
        /// <returns></returns>
        public T Get()
        {
            T tempRef;

            if (maxPriority > 0)
                --maxPriority;
            if (middlPriority > 0)
                --middlPriority;

            tempRef = listOfElements[0];
            listOfElements.RemoveAt(0);

            return tempRef;
        }
        /// <summary>
        /// Удаление элементов с указаным приорететом
        /// </summary>
        /// <param name="priority">приоретет удаляемых элементов</param>
        public void Drop(int priority)
        {
            if (priority <= -1)
            {
                listOfElements.RemoveRange(middlPriority, 
                                           listOfElements.Count - middlPriority);
            }

            else if (priority >= 1)
            {
                listOfElements.RemoveRange(0, maxPriority);
                maxPriority = 0;
            }

            else
            {
                listOfElements.RemoveRange(maxPriority, middlPriority - maxPriority);
                middlPriority = maxPriority;
            }
        }
        /// <summary>
        /// Печать элементов очереди в хранимом порядке
        /// </summary>
        public void Print()
        {
            foreach(T t in listOfElements)
                Console.WriteLine(t);
        }
    }
}
