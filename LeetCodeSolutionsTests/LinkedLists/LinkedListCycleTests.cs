using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.LinkedLists.Tests
{
    [TestClass()]
    public class LinkedListCycleTests
    {
        [TestMethod()]
        public void HasCycleTest_false()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            Assert.IsTrue(LinkedListCycle.HasCycle(head) == false);
        }

        [TestMethod()]
        public void HasCycleTest_true()
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            head.next.next.next.next.next = head.next; //create a cycle.
            Assert.IsTrue(LinkedListCycle.HasCycle(head) == true);
        }
    }
}