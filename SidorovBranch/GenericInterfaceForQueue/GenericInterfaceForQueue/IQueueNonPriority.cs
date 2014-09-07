using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericInterfaceForQueue
{
    interface IQueueNonPriority<T>
    {
        void Put(T someTypeObj);
        T Get();
    }
}
