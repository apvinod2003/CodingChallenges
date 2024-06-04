namespace LeetCodeSolutions.TreesAndGraphs
{
    public class LowestCommonAncestorBST
    {
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while(root != null) {

                if (p.val < root.val && q.val < root.val)
                {
                    root = root.left;
                }
                else if(p.val > root.val && q.val > root.val)
                {
                    root = root.right;
                }
                else
                    return root;
            }

            return null;
        }
    }
}
