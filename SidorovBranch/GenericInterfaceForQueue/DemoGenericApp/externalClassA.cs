using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoGenericApp
{
    class externalClassA<T>
    {
        static int dataA;

        public class A1<T1, T2>
        {
            static int dataA1;

            static A1()
            {
                Console.WriteLine("T:{0}, T1:{1}, T2:{2}", 
                    typeof(T).Name, typeof(T1).Name, typeof(T2).Name);
            }

            public A1() { A1<T1, T2>.dataA1++; Console.WriteLine("dataA1:", dataA1); }
        }

        public class A2
        {
            static int dataA2;

            static A2()
            {
                Console.WriteLine("T: {0}", typeof(T).Name);
            }

            public A2() { A2.dataA2++; Console.WriteLine("dataA2:", dataA2); }
        }

        public externalClassA() { externalClassA<T>.dataA++; Console.WriteLine("dataA:", dataA); }
    }
}
