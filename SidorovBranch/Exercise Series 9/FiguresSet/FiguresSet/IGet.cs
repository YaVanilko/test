using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresSet
{
    interface IGet<out T>
    {
        T Get(int index);
        int Length { get; }
    }
}
