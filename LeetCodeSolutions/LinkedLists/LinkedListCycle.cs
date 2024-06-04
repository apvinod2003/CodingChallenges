namespace LeetCodeSolutions.LinkedLists
{

    public class LinkedListCycle
    {
        public static bool HasCycle(ListNode head)
        {
            ListNode ptr1x = head, ptr2x = head;
            
            while (ptr2x != null && ptr2x.next != null)
            {
                ptr1x = ptr1x.next;
                ptr2x = ptr2x.next.next;

                if (ptr1x == ptr2x)
                    return true;
            }

            return false;

        }
    }
    
    
}
