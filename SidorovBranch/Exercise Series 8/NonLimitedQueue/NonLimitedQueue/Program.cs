using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NonLimitedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menusList = new List<string>();
            menusList.Add("Add element");
            menusList.Add("Get element");
            menusList.Add("-------Exit");

            Queue<char> TestQueue = new Queue<char>();

            bool key = true;
            do
            {
                switch (MenusFunc(menusList) + 1)
                {
                    case 1:
                        TestQueue.Put(char.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine(TestQueue.Get());
                        break;
                    default:
                        key = !key;
                        break;
                }
            } while (key);

        }

        static int MenusFunc(List<string> ListOfPoint)
        {
            for (int i = 0; i < ListOfPoint.Count; ++i)
            {
                Console.WriteLine("[ {0} ] {1}", i + 1, ListOfPoint[i]);
            }
            return int.Parse(Console.ReadLine()) - 1;
        }
    }

    class Queue<T> where T : struct
    {
        public Cell<T> tailOfQueue { get; private set; }

        public void Put(T someData)
        {
            this.tailOfQueue = new Cell<T>(this.tailOfQueue, someData);
        }

        public T Get()
        {
            Cell<T> tempRef = tailOfQueue;
            T tempData;

            if (tempRef.PreviousCell == null)
            {
                tempData = tailOfQueue.SomeData;
                tailOfQueue = null;
                return tempData;
            }

            do {
                tempRef = tempRef.PreviousCell;
            } while (tempRef.PreviousCell != null);

            tempData = tempRef.PreviousCell.SomeData;
            tempRef.PreviousCell = null;

            return tempData;
        }
    }

    class Cell<T>
    {
        public Cell<T> PreviousCell { get; set; }
        public T SomeData { get; private set; }

        public Cell(Cell<T> PreviousCell, T SomeData)
        {
            this.PreviousCell = PreviousCell;
            this.SomeData = SomeData;
        }
    }
}
