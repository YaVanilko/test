﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelvesColection
{
    class Program
    {
        static void Main(string[] args)
        {

            IShelves<string> c = new Shelves<string>();
            c.Add(1, " - D on shelf 1 - ");
            c.Add(1, " - 2 on shelf 1 - ");
            c.Add(2, " - 3 on shelf 2 - ");
            c.Add(2, " - W on shelf 2 - ");
            c.Add(2, " - G on shelf 2 - ");
            c.Add(3, " - D on shelf 3 - ");
            c.Add(3, " - 7 on shelf 3 - ");
            c.Add(4, " - T on shelf 4 - ");
            c.Add(4, " - 9 on shelf 4 - ");
            c.Add(4, " - Z on shelf 4 - ");

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // output: everything from every shelf

            var it = c.GetEnumeratorForLevel(2);
            while (it.MoveNext())
            {
                Console.WriteLine(it.Current);
            }
            // output: everything from 1st shelf

            Console.ReadKey();
        }
    }

    public interface IShelves<T> : IEnumerable<T>
    {
        void Add(int level, T data);
        // ... implement standard enumerable methods
        IEnumerator<T> GetEnumeratorForLevel(int level);
    }

    public class Shelves<T> : IShelves<T>
    {
        private List<List<T>> elements;

        public Shelves()
        {
            elements = new List<List<T>>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (List<T> lt in elements)
            {
                foreach (T t in lt)
                {
                    yield return t;
                }
            }
        }

        public IEnumerator<T> GetEnumeratorForLevel(int level)
        {
            return elements[level - 1].GetEnumerator();
        }
        public void Add(int level, T data)
        {
            while(elements.Count < level)
            {
                elements.Add(new List<T>());
            }
            elements[level - 1].Add(data);
        }
    }
}
