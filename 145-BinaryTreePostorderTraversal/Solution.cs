namespace BinaryTreePostorderTraversal
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        List<int> paths = new List<int>();
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null)
                return new List<int>();
            if (root.left == null && root.right == null)
                return new List<int> { root.val };
            postorderTraversal(root);
            return paths;
        }
        public void postorderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            postorderTraversal(node.left);
            postorderTraversal(node.right);
            paths.Add(node.val);

        }
    }
}