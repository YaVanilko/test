using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GenericInterfaceForQueue;

namespace UnitTesting
{
    [TestFixture]
    class PritGetQueueTest
    {

        [Test]
        public void SimpleTest()
        {
            PriorityQueueL<int> TestQueue = new PriorityQueueL<int>();

            TestQueue.Put(5, 0);

            Assert.AreEqual(5, TestQueue.Get());

            Assert.Throws<ApplicationException>(()=>TestQueue.Get());
        }
//
    }
}
