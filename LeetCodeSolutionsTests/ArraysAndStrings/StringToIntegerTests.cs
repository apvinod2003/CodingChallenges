using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class StringToIntegerTests
    {
        private StringToInteger stoi;
        public StringToIntegerTests()
        {
            stoi = new StringToInteger();
        }
        [TestMethod()]
        public void MyAtoiTest()
        {
            Assert.IsTrue(stoi.MyAtoi("   -42") == -42);
        }

        [TestMethod()]
        public void MyAtoiTest3()
        {
            Assert.IsTrue(stoi.MyAtoi("    +176abc") == 176);
        }

        [TestMethod()]
        public void MyAtoiTest1()
        {
            Assert.IsTrue(stoi.MyAtoi("4193 with words") == 4193);
        }

        [TestMethod()]
        public void MyAtoiTest2()
        {
            Assert.IsTrue(stoi.MyAtoi("startswith123") == 0);
        }
    }
}