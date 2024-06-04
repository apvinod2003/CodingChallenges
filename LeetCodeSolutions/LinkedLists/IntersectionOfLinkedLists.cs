namespace LeetCodeSolutions.LinkedLists
{
    public class IntersectionOfLinkedLists
    {
        /// <summary>
        /// Approach is to traverse both lists one node at a time and check if both nodes intersect, until you reach end of each list.
        /// at this point we swap the current pointers to head of other list and traverse untill we find an intersection.
        /// If two lists don't intersect,  both the pointers will reach end at the same instance (during second iteration).
        /// Return null after two iterations if intersection not found.
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode currA = headA;
            ListNode currB = headB;

            while(currA != currB && !( currA == null && currB == null))
            {
                currA = currA == null ? headB : currA.next;
                currB = currB == null ? headA : currB.next;
            }

            return currA;
        }
    }
}
