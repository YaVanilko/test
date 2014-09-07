using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoGenericApp
{
    class Program
    {
        static void Main(string[] args)
        {
            externalClassA<int>.A1<int, int> val1 = new externalClassA<int>.A1<int, int>();

            externalClassA<int>.A1<char, string> val2 = new externalClassA<int>.A1<char, string>();

            externalClassA<int>.A2 val3 = new externalClassA<int>.A2();

            externalClassA<string>.A1<int, int> val4 = new externalClassA<string>.A1<int, int>();

            externalClassA<char>.A1<char, string> val5 = new externalClassA<char>.A1<char, string>();

            externalClassA<string>.A2 val6 = new externalClassA<string>.A2();



        }
    }
}
