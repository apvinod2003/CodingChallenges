namespace LeetCodeSolutions.LinkedLists
{
    public class AddTwoNumbers1
    {
        /// <summary>
        /// Approach
        /// Traverse both lists to gether and Add digits from each list, storing carry in a temp variable, and adding carry during next iteration. 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode();
            ListNode curr = head;
            int carry = 0;
            int sum = 0;

            while(l1 != null || l2 != null || carry > 0)
            {
                sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;

                if(sum >=10)
                {
                    carry = 1;
                    sum %= 10;
                }
                else
                {
                    carry = 0;
                }
                
                curr.next = new ListNode(sum);
                curr = curr.next;

                l1 = l1?.next; 
                l2 = l2?.next;
            }


            return head.next;
        }
    }
}
