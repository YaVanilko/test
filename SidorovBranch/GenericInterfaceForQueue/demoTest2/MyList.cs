using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demoTest2
{
    class MyList<T>: IPut<T>, IGet<T> 
    {

        public void Put(T t)
        {

        }

        public T GetAt(int index)
        {

            throw new ApplicationException();
        }
    }
}
