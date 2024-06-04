using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.LinkedLists.Tests
{
    [TestClass()]
    public class ReverseLinkedListsTests
    {
        [TestMethod()]
        public void ReverseListTest()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            ListNode tail = ReverseLinkedLists.ReverseList(head);
            int i = 5;
            while (tail != null)
            {
                Assert.IsTrue(tail.val == i);
                i--;
                tail = tail.next;
            }
        }
    }
}