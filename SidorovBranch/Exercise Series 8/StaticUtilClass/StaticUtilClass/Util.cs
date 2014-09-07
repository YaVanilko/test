using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticUtilClass
{
    static class Util
    {
        public static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }

        public static T Max<T>(T first, T second) where T : IComparable
        {
            if (first.CompareTo(second) >= 0)
                return first;
            return second;
        }

        public static T Max<T>(T first, T second, T third) where T : IComparable
        {
            return Max<T>(Max<T>(first, second), third);
        }

        public static T Min<T>(T first, T second) where T : IComparable
        {
            if (first.CompareTo(second) <= 0)
                return first;
            return second;
        }

        public static T Min<T>(T first, T second, T third)where T : IComparable
        {
            return Min<T>(Min<T>(first, second), third);
        }
    }
}
