using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class ReverseStringsTests
    {
        private ReverseStrings rvs;
        public ReverseStringsTests()
        {
            rvs = new ReverseStrings();
        }
        [TestMethod()]
        public void ReverseStringTest()
        {
            char[] c = ['a', 'b', 'c'];
            rvs.ReverseString(c);
            Assert.IsTrue(new string(c) == "cba");
        }



        [TestMethod()]
        public void ReverseStringTest1()
        {
            char[] c = [];
            rvs.ReverseString(c);
            Assert.IsTrue(c.Length == 0);
        }


        [TestMethod()]
        public void ReverseStringTest2()
        {
            char[] c = ['2', '3', 'x'];
            rvs.ReverseString(c);
            Assert.IsTrue(new string(c) == "x32");
        }
    }
}