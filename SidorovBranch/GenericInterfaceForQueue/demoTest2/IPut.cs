using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demoTest2
{
    interface IPut<in T>
    {
        public void Put(T t);
    }
}
