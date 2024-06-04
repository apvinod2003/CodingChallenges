using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class ReverseWordsInStringTests
    {
        private ReverseWordsInString rwis;
        public ReverseWordsInStringTests()
        {
            rwis = new ReverseWordsInString();
        }
        [TestMethod()]
        public void ReverseWordsTest()
        {
            Assert.IsTrue(rwis.ReverseWords("the sky is blue") == "blue is sky the");
        }

        [TestMethod()]
        public void ReverseWordsTest1()
        {
            Assert.IsTrue(rwis.ReverseWords("  hello world  ") == "world hello");
        }
    }
}