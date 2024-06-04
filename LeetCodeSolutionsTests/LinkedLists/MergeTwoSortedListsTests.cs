using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.LinkedLists.Tests
{
    [TestClass()]
    public class MergeTwoSortedListsTests
    {
        [TestMethod()]
        public void MergeTwoListsTest()
        {
            ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
            ListNode head2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));

            ListNode result = MergeTwoSortedLists.MergeTwoLists(head1, head2);

            Assert.IsTrue(result.val == 1 && result.next.val == 1 && result.next.next.val == 2 && result.next.next.next.val == 3 && result.next.next.next.next.val == 4 && result.next.next.next.next.next.val == 4);
        }
    }
}