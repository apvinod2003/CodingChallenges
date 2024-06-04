namespace LeetCodeSolutions.LinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class ReverseLinkedLists
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;
            ListNode temp;
            while (curr != null) { 
                temp = curr;
                curr = curr.next;
                temp.next = prev;
                prev = temp;
            }
            return prev;
        }
    }
}
