using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace UnitTestProjectTask1
{
    [TestClass]
    public class Task1Tests
    {
        [TestMethod]
        public void ChessBoard_3on3()
        {
            ChessBoard cb = new ChessBoard(3, 3);
            string actual = cb.ToString();
            string expected = "* *\r\n * \r\n* *\r\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChessBoard_2on2()
        {
            ChessBoard cb = new ChessBoard(2, 2);
            string actual = cb.ToString();
            string expected = "* \r\n *\r\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChessBoard_3on2()
        {
            ChessBoard cb = new ChessBoard(3, 2);
            string actual = cb.ToString();
            string expected = "* \r\n *\r\n* \r\n";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChessBoard_2on3()
        {
            ChessBoard cb = new ChessBoard(2, 3);
            string actual = cb.ToString();
            string expected = "* *\r\n * \r\n";
            Assert.AreEqual(expected, actual);
        }
    }
}
