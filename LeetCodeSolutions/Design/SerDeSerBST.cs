using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions.TreesAndGraphs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeSolutions.Design
{
    public class SerDeSerBST
    {
        //Use Preorder dfs traversal to serialize.
        public string serialize(TreeNode root)
        {
            if (root == null)
            {
                return "N";
            }
            return root.val + "," + serialize(root.left) + "," + serialize(root.right);
            
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            string[] str = data.Split(",");
            int index = 0;

            TreeNode ConstructNode()
            {
                if (str[index] == "N")
                {
                    index++;
                    return null;
                }


                TreeNode node = new TreeNode(int.Parse(str[index]));
                index++;

                node.left = ConstructNode();
                node.right = ConstructNode();

                return node;
            }

            return ConstructNode();
        }

        

    }
}
