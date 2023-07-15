namespace BinaryTreePaths
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
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
                return new List<int>();
            if (root.left == null && root.right == null)
                return new List<int> { root.val };
            inorderTraversal(root);
            return paths;
        }
        public void inorderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            inorderTraversal(node.left);
            paths.Add(node.val);
            inorderTraversal(node.right);

        }
    }
}