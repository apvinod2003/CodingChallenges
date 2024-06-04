namespace LeetCodeSolutions.LinkedLists
{
    public  class AddTwoNumbersII
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Stack<int> s1 = GetStack(l1);
            Stack<int> s2 = GetStack(l2);

            int sum = 0, carry = 0;
            ListNode head = null;

            while(s1.Count > 0 || s2.Count > 0 || carry > 0) 
            {
                sum = (s1.Count > 0 ? s1.Pop() : 0) + (s2.Count > 0 ? s2.Pop() : 0) + carry;
                if(sum >= 10)
                {
                    carry = 1;
                    sum = sum % 10;
                }
                else
                    carry = 0;

                head = new ListNode(sum, head);
            }

            return head;
        }

        private static Stack<int> GetStack(ListNode l)
        {
            Stack<int> stack = new Stack<int>();
            ListNode curr = l;
            while (curr != null)
            {
                stack.Push(curr.val);
                curr = curr.next;
            }

            return stack;
        }
    }
}
