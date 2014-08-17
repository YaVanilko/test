using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace TreeTask
{

    class Person : IComparable<Person>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public int CompareTo(Person person)
        {
            if (this.Age > person.Age)
            {
                return 1;
            }
            else if (this.Age < person.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    class Program
    {
        // MAIN PROGRAM:

        /* Create data type Person.
         * Create graph of somebody's ancestors based on BinaryTree. Your program 
         * should perform search in this tree by name and birth year (older or younger
         * than some year).
         * 
         * Create graph of somebody's descendants based on Tree. 
         * Your program should perform search in this tree by name and birth 
         * year (older or younger than some year). */

        static void Main(string[] args)
        {
            BinaryTree<Person> myTree = 
                new BinaryTree<Person>(new Person("Вася", 15), null);

            myTree.AddChild(new Person("Коля", 7));
            myTree.AddChild(new Person("Петя", 8));
            myTree.AddChild(new Person("Саша", 16));
            myTree.AddChild(new Person("Вова", 18));
            myTree.AddChild(new Person("Игор", 19));
            myTree.AddChild(new Person("Митя", 20));
            myTree.AddChild(new Person("Джек", 30));
            myTree.AddChild(new Person("Джон", 40));
            myTree.AddChild(new Person("Питр", 4));
            myTree.AddChild(new Person("Гари", 25));
            myTree.AddChild(new Person("Ричи", 12));

            // Попытка добавить имеющегося Человека не изменяет состояния дерева
            myTree.AddChild(new Person("Ричи", 12));
            myTree.AddChild(new Person("Ричи", 12));
            myTree.AddChild(new Person("Ричи", 12));

            Comparison<Person> d1 = (x, y) => x.CompareTo(y);
            Comparison<Person> d2 = (x, y) => 1 - x.CompareTo(y);

            // Выводим людей, возрас которых больше узла myTree (Правая часть дерева)
            foreach (var t in myTree.Find(d1))
                Console.WriteLine("Имя: '{0}',  Возраст: {1} лет", 
                    t.Data.Name, t.Data.Age);

            Console.WriteLine();

            // Выводим людей, возрас которых меньше узла myTree (Левая часть дерева)
            foreach (var t in myTree.Find(d2))
                Console.WriteLine("Имя: '{0}',  Возраст: {1} лет", 
                    t.Data.Name, t.Data.Age);

            Console.WriteLine();

            foreach (var t in myTree)
                Console.WriteLine("Имя: '{0}',  Возраст: {1} лет",
                    t.Name, t.Age);

            Console.ReadKey();
        }
    }




    interface IBaseTree<T> : IEnumerable<T>, ICloneable
    {
        T Data { get; set; }
        IBaseTree<T> Parent { get; }

        /// <summary>
        /// find all nodes which will suit comparison condition
        /// </summary>
        /// <param name="c">comparison conditions</param>
        /// <returns>list of handles</returns>

        IList<IBaseTree<T>> Find(Comparison<T> c);

        /// <summary>
        /// returns list of all direct children
        /// </summary>
        /// <returns>list of subtrees</returns>

        IList<IBaseTree<T>> GetDirectChildren();

    }

    interface ITree<T> : IBaseTree<T>
    {
        /// <summary>
        /// adds child
        /// </summary>
        /// <param name="data">data to add in child</param>
        /// <returns>new child reference</returns>

        ITree<T> AddChild(T data);

        /// <summary>
        /// returns true on successfull removal or false if @t is null or not direct child
        /// </summary>
        /// <param name="t">subtree to remove</param>
        /// <returns>status</returns>

        bool RemoveChild(ITree<T> t);
    }

    interface IBinaryTree<T> : IBaseTree<T>
    {
        T              LeftData  { get; }
        T              RightData { get;  }
        IBinaryTree<T> Left { get; }
        IBinaryTree<T> Right { get; }

        void AddChild(T data);
    }

    abstract class BaseTree<T> : IBaseTree<T>
    {
        protected IList<IBaseTree<T>> Children;
        public T Data { get; set; }
        public IBaseTree<T> Parent { get; private set; }


        public BaseTree(T data, IBaseTree<T> parent)
        {
            Children = new List<IBaseTree<T>>();
            this.Data = data;
            this.Parent = parent;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IBaseTree<T> FindRoot(IBaseTree<T> link)
        {
            if (link.Parent == null)
            {
                return link;
            }
            else
            {
                return FindRoot(link.Parent);
            }
        }

        public virtual IList<IBaseTree<T>> Find(Comparison<T> c)
        {
            return Find(c, FindRoot(this));
        }

        public virtual IList<IBaseTree<T>> Find(Comparison<T> c, IBaseTree<T> nodLink)
        {
            IList<IBaseTree<T>> tempList = new List<IBaseTree<T>>();

            GetNod(nodLink, tempList, c, this);

            return tempList;
        }

        public IList<IBaseTree<T>> GetDirectChildren()
        {
            return Children;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return FindRoot(this).GetDirectChildren().
                Select(x => x.Data).ToList<T>().GetEnumerator();
        }

        public Object Clone()
        {
            return (Object)this;
        }

        protected void GetNod(IBaseTree<T> currentNod,
                       IList<IBaseTree<T>> tempList,
                       Comparison<T> c,
                       IBaseTree<T> compareLink)
        {
            for (int i = 0; i < currentNod.GetDirectChildren().Count; ++i)
            {
                if (c(currentNod.GetDirectChildren()[i].Data, Data) > 0)
                {
                    tempList.Add(currentNod.GetDirectChildren()[i]);
                }

                GetNod(currentNod.GetDirectChildren()[i], tempList, c, compareLink);
            }
        }
    }

    class Tree<T> : BaseTree<T>, ITree<T>
    {
        public Tree(T data, IBaseTree<T> parent) : base(data, parent) { }

        public ITree<T> AddChild(T data)
        {
            ITree<T> tmp = new Tree<T>(data, this);

            Children.Add(tmp);

            return tmp;
        }

        public bool RemoveChild(ITree<T> t)
        {
            return Children.Remove(t);
        }
    }

    class BinaryTree<T> : BaseTree<T>, IBinaryTree<T>
        where T : IComparable<T>
    {
        public T LeftData { get; private set; }
        public T RightData { get; private set; }

        public IBinaryTree<T> Left { get; private set; }
        public IBinaryTree<T> Right { get; private set; }

        public BinaryTree(T data, IBaseTree<T> parent)
            : base(data, parent) { }

        public void AddChild(T data)
        {
            if (data.CompareTo(Data) > 0)
            {
                if (Right == null)
                {
                    Right = new BinaryTree<T>(data, this);
                    RightData = data;
                    Children.Add(Right);
                }
                else
                {
                    Right.AddChild(data);
                }
            }
            else if (data.CompareTo(Data) < 0)
            {
                if (Left == null)
                {
                    Left = new BinaryTree<T>(data, this);
                    LeftData = data;
                    Children.Add(Left);
                }
                else
                {
                    Left.AddChild(data);
                }
            }
        }
    }
}



