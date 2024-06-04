using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Design.Tests
{
    [TestClass()]
    public class LRUCacheTests
    {
        LRUCache obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new LRUCache(3);
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void TestLRUCache()
        {
            obj.Put(1, 1);
            obj.Put(2, 2);
            obj.Put(3, 3);
            obj.Put(4, 4);

            Assert.IsTrue(obj.Get(1) == -1);

            obj.Get(2);

            obj.Put(5, 5);

            Assert.IsTrue(obj.Get(3) == -1);

        }
    }
}