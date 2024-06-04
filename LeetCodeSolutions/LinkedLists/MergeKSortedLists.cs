namespace LeetCodeSolutions.LinkedLists
{
    public class MergeKSortedLists
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            int len = lists.Length;
            if (lists == null || len == 0) return null;

            if(len == 1) return lists[0];

            int mid = len / 2;

            return MergeTwoLists(MergeKLists(lists[0..mid]), MergeKLists(lists[mid..len]));
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode(0);
            ListNode curr = head;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    curr.next = list2;
                    list2 = list2.next;
                }

                curr = curr.next;
            }

            curr.next = list1 == null ? list2 : list1;

            return head.next;
        }
    }
}
