using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresSet
{
    interface IPut<in T>
    {
        void Add(T t);
    }
}
