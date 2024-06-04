using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.LinkedLists.Tests
{
    [TestClass()]
    public class AddTwoNumbers1Tests
    {
        [TestMethod()]
        public void AddTwoNumbersTest()
        {
            ListNode head1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            ListNode head2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            ListNode result = AddTwoNumbers1.AddTwoNumbers(head1, head2);

            Assert.IsTrue(result.val == 7 && result.next.val == 0 && result.next.next.val == 8);
        }
    }
}