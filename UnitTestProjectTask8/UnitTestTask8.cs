using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task8;

namespace UnitTestProjectTask8
{
    [TestClass]
    public class UnitTestTask8
    {
        [TestMethod]
        public void FibonacciNumbersBoundsWithFibonacciNumber()
        {
            int a = 5;
            int b = 144;
            string expected = "5,8,13,21,34,55,89,144";

            FibonacciNumbers fb = new FibonacciNumbers(a, b);
            string actual = fb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciNumbersBoundsWithOneNumber()
        {
            int a = 5;
            int b = 5;
            string expected = "5";

            FibonacciNumbers fb = new FibonacciNumbers(a, b);
            string actual = fb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciNumbersBoundsWithSmallUsualValues()
        {
            int a = 4;
            int b = 50;
            string expected = "5,8,13,21,34";

            FibonacciNumbers fb = new FibonacciNumbers(a, b);
            string actual = fb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciNumbersBoundsWithBigUsualValues()
        {
            double a = 39088168;
            double b = 53316291174;
            string expected = "39088169,63245986,102334155,165580141,267914296,433494437," +
                "701408733,1134903170,1836311903,2971215073,4807526976,7778742049,12586269025," +
                "20365011074,32951280099,53316291173";

            FibonacciNumbers fb = new FibonacciNumbers(a, b);
            string actual = fb.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciNumbersFindFibonacciByIndex_5()
        {
            FibonacciNumbers fb = new FibonacciNumbers();
            double actual = fb.FindFibonacciNumber(5);
            double expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciNumbersFindFibonacciByIndex_11()
        {
            FibonacciNumbers fb = new FibonacciNumbers();
            double actual = fb.FindFibonacciNumber(11);
            double expected = 89;
            Assert.AreEqual(expected, actual);
        }
    }
}
