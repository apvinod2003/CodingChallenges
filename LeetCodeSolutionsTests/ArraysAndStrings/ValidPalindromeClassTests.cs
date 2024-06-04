using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class ValidPalindromeClassTests
    {
        private ValidPalindromeClass vpc;
        public ValidPalindromeClassTests()
        {
            vpc = new ValidPalindromeClass();
        }
        [TestMethod()]
        public void IsPalindromeTest_True()
        {
            Assert.IsTrue(vpc.IsPalindrome("A man, a plan, a canal: Panama"));
        }

        [TestMethod()]
        public void IsPalindromeTest_False()
        {
            Assert.IsFalse(vpc.IsPalindrome("race a car"));
        }

        [TestMethod()]
        public void IsPalindromeTest1()
        {
            Assert.IsTrue(vpc.IsPalindrome("a."));
        }
    }
}