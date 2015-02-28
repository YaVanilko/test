using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresSet
{
    class MyList<T> : IGet<T>, IPut<T>
    {
        private List<T> l = new List<T>();

        public int Length { get { return l.Count; } }

        public T Get(int index)
        {
            if (index >= Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            return l[index];
        }
        public void Add(T t)
        {
            l.Add(t);
        }

        public void AddRange(IGet<T> t)
        {
            for (int i = 0; i < t.Length; ++i )
            {
                l.Add(t.Get(i));
            }
        }
    }
}
