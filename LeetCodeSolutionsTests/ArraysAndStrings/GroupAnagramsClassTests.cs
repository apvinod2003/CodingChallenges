using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.ArraysAndStrings.Tests
{
    [TestClass()]
    public class GroupAnagramsClassTests
    {
        private GroupAnagramsClass gac;
        public GroupAnagramsClassTests()
        {
                gac = new GroupAnagramsClass();
        }
        [TestMethod()]
        public void GroupAnagramsTest()
        {
            string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

            Assert.IsTrue(gac.GroupAnagrams(strs)[0].Count == 3);
            Assert.IsTrue(gac.GroupAnagrams(strs)[1].Count == 2);
            Assert.IsTrue(gac.GroupAnagrams(strs)[2].Count == 1);
        }
    }
}