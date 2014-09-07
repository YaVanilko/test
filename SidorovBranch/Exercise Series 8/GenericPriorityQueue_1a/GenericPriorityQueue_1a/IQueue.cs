using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericPriorityQueue_1a
{
    interface IQueue<T>
    {
        void Put(T someTypeObj, int priority);
        T Get();
        void Drop(int priority);
    }
}
