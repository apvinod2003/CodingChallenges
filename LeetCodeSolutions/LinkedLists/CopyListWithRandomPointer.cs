namespace LeetCodeSolutions.LinkedLists
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    /// <summary>
    /// Approach
    /// In a loop: Interleave new nodes after existing ones.
    /// In a loop: Set Random pointer for new nodes: currNew.random = curr.random.next
    /// In a loop: Seperate the old and new nodes to its own lists.
    /// </summary>
    public class CopyListWithRandomPointer
    {
        public static Node CopyRandomList(Node head)
        {
            if (head == null) return null;
            
            Node curr = head;
            Node temp, newHead, currNew;

            //Interleave new nodes
            while (curr != null)
            {
                temp = new Node(curr.val);
                //Insert temp in the list after curr
                temp.next = curr.next;
                curr.next = temp;
                curr = curr.next.next; // since temp is in middle, move twice to get the next original element.
            }

            //Set random pointers for newly created nodes.
            curr = head;
            currNew = newHead = head.next;

            while(currNew != null)
            {
                currNew.random = curr.random?.next;
                currNew = currNew.next?.next; //two hops since original and copied nodes are interleaved.
                curr = curr.next?.next;
            }

            curr = head;
            currNew = newHead = head.next;

            //seperate original and new nodes to respective linked lists.
            while(currNew != null)
            {
                curr.next = curr.next.next;
                curr = curr.next;
                currNew.next = currNew.next?.next;
                currNew = currNew.next;
            }

            return newHead;

        }
    }
}
