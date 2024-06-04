namespace LeetCodeSolutions.TreesAndGraphs.Graphs
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
    public class CloneGraphClass
    {
        public static Dictionary<Node,Node> dict = new Dictionary<Node,Node>();
        public static Node CloneGraph(Node node)
        {
            if (node == null) { return null; }

            if(!dict.ContainsKey(node)) 
            {
                Node cloned = new Node(node.val);
                dict.Add(node, cloned);
                foreach(Node n in node.neighbors)
                {   
                    cloned.neighbors.Add(CloneGraph(n));
                }
            }

            return dict[node];
        }
    }
}
