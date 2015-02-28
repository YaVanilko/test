using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math
{
    public class MyMath
    {

        public static int Factorial(int n)
        {
            checked
            {
                if (n < 0)
                {
                    throw new OverflowException(@"
                              Аргумент вне границ допустимого диапазона");
                }

                int temp = 1;
                for (int i = 1; i <= n; ++i)
                    temp *= i;
                return temp;
            }
        }
    }
}
