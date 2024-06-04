using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Others.Tests
{
    [TestClass()]
    public class IntegetToEnglishWordsTests
    {
        IntegetToEnglishWords obj;
        // This method runs before each MSTest test method
        [TestInitialize]
        public void Setup()
        {
            obj = new IntegetToEnglishWords();
        }

        // This method runs after each MSTest test method
        [TestCleanup]
        public void Teardown()
        {
            obj = null;
        }

        [TestMethod()]
        public void NumberToWordsTest()
        {
            Assert.IsTrue(obj.NumberToWords(12345) == "Twelve Thousand Three Hundred Forty Five");
        }

        [TestMethod()]
        public void NumberToWordsTest1()
        {
            Assert.IsTrue(obj.NumberToWords(0) == "Zero");
        }

        [TestMethod()]
        public void NumberToWordsTest2()
        {
            Assert.IsTrue(obj.NumberToWords(123) == "One Hundred Twenty Three");
        }

        [TestMethod()]
        public void NumberToWordsTest3()
        {
            Assert.IsTrue(obj.NumberToWords(30) == "Thirty");
        }

        [TestMethod()]
        public void NumberToWordsTest4()
        {
            Assert.IsTrue(obj.NumberToWords(50868) == "Fifty Thousand Eight Hundred Sixty Eight");
        }

        [TestMethod()]
        public void NumberToWordsTest5()
        {
            Assert.IsTrue(obj.NumberToWords(1000000) == "One Million");
        }
    }
}