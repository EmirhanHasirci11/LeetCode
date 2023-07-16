namespace BinaryTreePreorderTraversal
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
        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
                return new List<int>();
            if (root.left == null && root.right == null)
                return new List<int> { root.val };
            preorderTraversal(root);
            return paths;
        }
        public void preorderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            paths.Add(node.val);
            preorderTraversal(node.left);
            preorderTraversal(node.right);

        }
    }
}