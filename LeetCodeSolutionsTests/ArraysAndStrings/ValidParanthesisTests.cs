using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class ValidParanthesisTests
    {
        private ValidParanthesis vp;    
        public ValidParanthesisTests()
        {
            vp = new ValidParanthesis();
        }
        [TestMethod()]
        public void IsValidTest()
        {
            Assert.IsTrue(vp.IsValid("()") == true);
        }

        [TestMethod()]
        public void IsValidTest1()
        {
            Assert.IsTrue(vp.IsValid("()[]{}") == true);
        }

        [TestMethod()]
        public void IsValidTest2()
        {
            Assert.IsTrue(vp.IsValid("(]") == false);
        }

        [TestMethod()]
        public void IsValidTest3()
        {
            Assert.IsTrue(vp.IsValid("(()") == false);
        }
    }
}