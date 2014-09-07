using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Math;


namespace UnitTest
{
    [TestFixture]
    class TestMyMath
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(MyMath.Factorial(0), 1);
            Assert.AreEqual(MyMath.Factorial(1), 1);
            Assert.AreEqual(MyMath.Factorial(2), 2);
            Assert.AreEqual(MyMath.Factorial(5), 120);

            Assert.Throws<OverflowException>(() => MyMath.Factorial(-1));

            Assert.Throws<OverflowException>(() => MyMath.Factorial(-5));

            Assert.Throws<OverflowException>(() => MyMath.Factorial(int.MaxValue));
            Assert.Throws<OverflowException>(() => MyMath.Factorial(int.MinValue));
        }
    }
}
