using System.Xml.Linq;

namespace N_aryTreePostorderTraversal
{

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    internal class Solution
    {
        public IList<int> Postorder(Node root)
        {
            List<int> res = new();
            Travel(root,res);
            return res;
        }
        public  void Travel(Node node,List<int> nodeList) 
        {
            if(node is not null)
            {
                foreach(Node child in node.children) 
                {
                    Travel(child, nodeList);
                }
                nodeList.Add(node.val);
            }
        }

    }
}