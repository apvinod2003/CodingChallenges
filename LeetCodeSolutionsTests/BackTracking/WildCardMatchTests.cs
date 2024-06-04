using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.BackTracking.Tests
{
    [TestClass()]
    public class WildCardMatchTests
    {
        WildCardMatch search;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            search = new WildCardMatch();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            search = null;
        }


        [TestMethod()]
        public void IsMatchTest()
        {
            Assert.IsTrue(!search.IsMatch("aa","a"));
        }



        [TestMethod()]
        public void IsMatchTest1()
        {
            Assert.IsTrue(search.IsMatch("adceb", "*a*b"));
        }

        [TestMethod()]
        public void IsMatchTest2()
        {
            Assert.IsTrue(!search.IsMatch("cb", "?a"));
        }
    }
}