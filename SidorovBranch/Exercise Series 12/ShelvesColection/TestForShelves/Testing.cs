using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShelvesColection;
using NUnit.Framework;

namespace TestForShelves
{
    [TestFixture]
    public class Testing
    {
        [Test]
        public static void Test1()
        {
            List<string> testBuffer = new List<string> {
                " - 1 on shelf 1 - ", 
                " - 2 on shelf 1 - ", 
                " - 3 on shelf 2 - ", 
                " - 4 on shelf 2 - ", 
                " - 5 on shelf 2 - ", 
                " - 6 on shelf 3 - ", 
                " - 7 on shelf 3 - ", 
                " - 8 on shelf 4 - ", 
                " - 9 on shelf 4 - ", 
                " - 0 on shelf 10 - "};

            IShelves<string> c = new Shelves<string>();
            c.Add(1, testBuffer[0]);
            c.Add(1, testBuffer[1]);
            c.Add(2, testBuffer[2]);
            c.Add(2, testBuffer[3]);
            c.Add(2, testBuffer[4]);
            c.Add(3, testBuffer[5]);
            c.Add(3, testBuffer[6]);
            c.Add(4, testBuffer[7]);
            c.Add(4, testBuffer[8]);
            c.Add(10, testBuffer[9]);

            // output: everything from every shelf
            int i = 0;
            foreach (var item in c)
            {
                Assert.AreEqual(item[4], testBuffer[i][4]);
                ++i;     
            }

            var it = c.GetEnumeratorForLevel(2);
            i = 0;
            while (it.MoveNext())
            {
                Assert.AreEqual(it.Current[4], testBuffer[i][4]);
                ++i;
            }
            
        }
    }
}
