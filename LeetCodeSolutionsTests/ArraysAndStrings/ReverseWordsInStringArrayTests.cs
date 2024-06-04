using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class ReverseWordsInStringArrayTests
    {
        private ReverseWordsInStringArray rwisa;
        public ReverseWordsInStringArrayTests()
        {
            rwisa = new ReverseWordsInStringArray();
        }
        [TestMethod()]
        public void ReverseWordsTest()
        {
            char[] s = ['t', 'h', 'e', ' ', 's', 'k', 'y', ' ', 'i', 's', ' ', 'b', 'l', 'u', 'e'];
            string str = "blue is sky the";
            rwisa.ReverseWords(s);
            string reversedstr = new string(s);
            Assert.IsTrue( reversedstr == str);
        }

        [TestMethod()]
        public void ReverseWordsTest1()
        {
            char[] s = ['a'];
            string str = "a";
            rwisa.ReverseWords(s);
            string reversedstr = new string(s);
            Assert.IsTrue(reversedstr == str);
        }
    }
}