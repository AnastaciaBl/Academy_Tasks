using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;
using System;

namespace UnitTestProjectTask3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AreaOfTriangle_3x2x4_()
        {
            Triangle t = new Triangle("t1", 3, 2, 4);
            double actual = t.findAreaOfTriangle();
            double expected = 2.9;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreaOfTriangle_6x4x7_()
        {
            Triangle t = new Triangle("t1", 6, 4, 7);
            double actual = t.findAreaOfTriangle();
            double expected = 11.98;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortedSetOfTriangles()
        {
            string actual = null, expected = null;
            Triangle[] tActual = new Triangle[]
            {
                new Triangle("t1", 4, 3, 5),
                new Triangle("t2", 2, 3, 2),
                new Triangle("t3", 5, 6, 7)
            };
            Array.Sort(tActual);
            foreach (Triangle t in tActual)
                actual += t.ToString() + "\n";
            Triangle[] tExpected = new Triangle[]
            {
                new Triangle("t2", 2, 3, 2),
                new Triangle("t1", 4, 3, 5),
                new Triangle("t3", 5, 6, 7)
            };
            foreach (Triangle t in tExpected)
                expected += t.ToString() + "\n";
            Assert.AreEqual(expected, actual);
        }
    }
}
