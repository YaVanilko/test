using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericInterfaceForQueue
{
    interface IQueue<T> : IQueueNonPriority<T>
    {
        void Put(T someTypeObj, int priority);
        void Drop(int priority);
    }
}
