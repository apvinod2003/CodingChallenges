using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.LinkedLists.Tests
{
    [TestClass()]
    public class MergeKSortedListsTests
    {
        [TestMethod()]
        public void MergeKListsTest()
        {
            ListNode head1 = new ListNode(1, new ListNode(4, new ListNode(5, null)));
            ListNode head2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));
            ListNode head3 = new ListNode(2, new ListNode(6, null));

            ListNode result = MergeKSortedLists.MergeKLists([head1, head2, head3]);

            Assert.IsTrue(result.val == 1 && result.next.val == 1 && result.next.next.val == 2 && result.next.next.next.val == 3 
                && result.next.next.next.next.val == 4 && result.next.next.next.next.next.val == 4 && result.next.next.next.next.next.next.val == 5 
                && result.next.next.next.next.next.next.next.val == 6);
        }
    }
}