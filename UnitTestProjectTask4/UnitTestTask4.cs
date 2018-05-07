using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;
using System.IO;

namespace UnitTestProjectTask4
{
    [TestClass]
    public class UnitTestTask4
    {
        [TestMethod]
        public void WordChange_text_on_NewText()
        {
            WordChange wc = new WordChange("test.txt", "text", "NewText");
            string actual;
            using (StreamReader sr = new StreamReader("test.txt"))
            {
                actual = sr.ReadToEnd();
            }
            string expected = wc.Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WordCount_NewText_2()
        {
            WordCounter wc = new WordCounter("test.txt", "NewText");
            int actual = wc.AmountOfCountWordInText;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WordChange_NewText_on_text()
        {
            WordChange wc = new WordChange("test.txt", "NewText", "text");
            string actual;
            using (StreamReader sr = new StreamReader("test.txt"))
            {
                actual = sr.ReadToEnd();
            }
            string expected = wc.Text;
            Assert.AreEqual(expected, actual);
        }
    }
}
