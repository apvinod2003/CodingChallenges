using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class LongestPalindromicSubstringTests
    {
        private LongestPalindromicSubstring spss;
        public LongestPalindromicSubstringTests()
        {
            spss = new LongestPalindromicSubstring();    
        }
        [TestMethod()]
        public void LongestPalindromeTest()
        {
            Assert.IsTrue(spss.LongestPalindrome("babad") == "bab" || spss.LongestPalindrome("babad") == "aba");
        }

        [TestMethod()]
        public void LongestPalindromeTest1()
        {
            Assert.IsTrue(spss.LongestPalindrome("cbbd") == "bb" );
        }

        [TestMethod()]
        public void LongestPalindromeTest2()
        {
            Assert.IsTrue(spss.LongestPalindrome("abcnitinbc") == "nitin");
        }

        [TestMethod()]
        public void LongestPalindromeTest3()
        {
            Assert.IsTrue(spss.LongestPalindrome("a") == "a");
        }
    }
}