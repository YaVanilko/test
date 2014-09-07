using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DiceGame;
using NUnit.Framework;
using Moq;

namespace TestOfGame
{
    [TestFixture]
    public class MoqTest
    {
        [Test]
        public static void Test1()
        {
            byte[] temp1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

            var mock = new Mock<IRandom>();

            mock.Setup(x => x.NextBytes(temp1));

            IRandom t;

            t = mock.Object;

            byte[] temp2 = MyClassForGame.MoveDiceGame(10, t);

            for(int i = 0; i < temp1.Length; ++i)
            {
                Assert.AreEqual(temp1[i], temp2[i]);
            }
            
        }
    }
}
