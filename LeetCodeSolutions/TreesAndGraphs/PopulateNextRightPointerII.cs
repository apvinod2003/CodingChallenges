namespace LeetCodeSolutions.TreesAndGraphs
{
    public class PopulateNextRightPointerII
    {
        public static Node Connect(Node root)
        {
            Node temp;
            Node firstNodeInLevel = root;
            Node currentRoot = root;

            while (firstNodeInLevel != null)
            {
                temp = null;
                firstNodeInLevel = null;
                while (currentRoot != null)
                {
                    if (currentRoot.left != null)
                    {
                        if (temp != null)
                        {
                            temp.next = currentRoot.left;
                            temp = temp.next;
                        }
                        else
                        {
                            temp = currentRoot.left; // temp will be null for the first node in a level
                            firstNodeInLevel = temp;
                        }

                    }
                    if (currentRoot.right != null)
                    {
                        if (temp != null)
                        {
                            temp.next = currentRoot.right;
                            temp = temp.next;
                        }
                        else
                        {
                            temp = currentRoot.right; // temp will be null for the first node in a level.
                            firstNodeInLevel = temp;
                        }
                    }
                    currentRoot = currentRoot.next; // traverse all the nodes in that level, and connect the child nodes.
                }
                currentRoot = firstNodeInLevel;
            }

            return root;
        }
        
    }
}
