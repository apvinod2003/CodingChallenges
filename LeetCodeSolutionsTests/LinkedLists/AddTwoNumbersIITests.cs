using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.LinkedLists.Tests
{
    [TestClass()]
    public class AddTwoNumbersIITests
    {
        [TestMethod()]
        public void AddTwoNumbersTest()
        {
            ListNode head1 = new ListNode(7, new ListNode(2, new ListNode(4, new ListNode(3, null))));
            ListNode head2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            ListNode result = AddTwoNumbersII.AddTwoNumbers(head1, head2);

            Assert.IsTrue(result.val == 7 && result.next.val == 8 && result.next.next.val == 0 && result.next.next.next.val == 7);
        }


        [TestMethod()]
        public void AddTwoNumbersTest1()
        {
            ListNode head1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            ListNode head2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            ListNode result = AddTwoNumbersII.AddTwoNumbers(head1, head2);

            Assert.IsTrue(result.val == 8 && result.next.val == 0 && result.next.next.val == 7 );
        }

        [TestMethod()]
        public void AddTwoNumbersTest2()
        {
            ListNode head1 = new ListNode(5, null);
            ListNode head2 = new ListNode(5, null);

            ListNode result = AddTwoNumbersII.AddTwoNumbers(head1, head2);

            Assert.IsTrue(result.val == 1 && result.next.val == 0 );
        }
    }
}