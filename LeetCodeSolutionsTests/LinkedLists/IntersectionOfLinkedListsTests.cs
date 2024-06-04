using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.LinkedLists.Tests
{
    [TestClass()]
    public class IntersectionOfLinkedListsTests
    {
        [TestMethod()]
        public void GetIntersectionNodeTest()
        {
            ListNode commonHead = new ListNode(8, new ListNode(4, new ListNode(5, null)));
            ListNode head1 = new ListNode(4, new ListNode(1, commonHead));
            ListNode head2 = new ListNode(5, new ListNode(6, new ListNode(1, commonHead)));

            var intersectingNode = IntersectionOfLinkedLists.GetIntersectionNode(head1, head2);

            Assert.IsNotNull(intersectingNode);
            Assert.IsTrue(intersectingNode.val == 8);
        }
    }
}