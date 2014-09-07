using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demoTest2
{
    interface IGet<out T>
    {
        public T GetAt(int index);
    }
}
