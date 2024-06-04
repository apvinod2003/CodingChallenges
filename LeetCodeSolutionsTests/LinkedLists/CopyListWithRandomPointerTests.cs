using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.LinkedLists.Tests
{
    [TestClass()]
    public class CopyListWithRandomPointerTests
    {
        [TestMethod()]
        public void CopyRandomListTest()
        {
            Node seven = new Node(7);
            Node thirteen = new Node(13);
            Node eleven = new Node(11);
            Node ten = new Node(10);
            Node one = new Node(1);

            seven.next = thirteen; seven.random = null;
            thirteen.next = eleven; thirteen.random = seven;
            eleven.next = ten; eleven.random = one;
            ten.next = one; ten.random = eleven;
            one.next = null; one.random = seven;

            var newhead = CopyListWithRandomPointer.CopyRandomList(seven);

            Assert.IsTrue(newhead.val == 7 && newhead.next.val == 13 && newhead.next.next.val == 11 && newhead.next.next.next.val == 10 && newhead.next.next.next.next.val == 1);

            Assert.IsTrue(newhead.random == null && newhead.next.random.val == 7 && newhead.next.next.random.val == 1 && newhead.next.next.next.random.val == 11 && newhead.next.next.next.next.random.val == 7);


        }
    }
}