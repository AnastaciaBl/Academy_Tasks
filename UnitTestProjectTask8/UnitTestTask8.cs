using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task8;

namespace UnitTestProjectTask8
{
    [TestClass]
    public class UnitTestTask8
    {
        [TestMethod]
        public void TestMethodNegativeBounds()
        {
            // исходные данные
            int a = -5;
            int b = 10;
            string expected = "0,1,1,2,3,5,8";

            FibonacciNumbers fb = new FibonacciNumbers(a, b);
            string actual = fb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBoundsWithFibonacciNumber()
        {
            // исходные данные
            int a = 5;
            int b = 144;
            string expected = "5,8,13,21,34,55,89,144";

            FibonacciNumbers fb = new FibonacciNumbers(a, b);
            string actual = fb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBoundsWithOneNumber()
        {
            // исходные данные
            int a = 5;
            int b = 5;
            string expected = "5";

            FibonacciNumbers fb = new FibonacciNumbers(a, b);
            string actual = fb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBoundsWithSmallUsualValues()
        {
            // исходные данные
            int a = 4;
            int b = 50;
            string expected = "5,8,13,21,34";

            FibonacciNumbers fb = new FibonacciNumbers(a, b);
            string actual = fb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodBoundsWithBigUsualValues()
        {
            // исходные данные
            double a = 39088168;
            double b = 53316291174;
            string expected = "39088169,63245986,102334155,165580141,267914296,433494437," +
                "701408733,1134903170,1836311903,2971215073,4807526976,7778742049,12586269025," +
                "20365011074,32951280099,53316291173";

            FibonacciNumbers fb = new FibonacciNumbers(a, b);
            string actual = fb.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
