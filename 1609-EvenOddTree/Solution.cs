namespace EvenOddTree
{
    public class Solution
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
        public bool IsEvenOddTree(TreeNode root)
        {
            if (root == null) return true;
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            bool even = true;
            while (queue.Count > 0)
            {
                int cnt = queue.Count;
                int prevVal = even ? int.MinValue : int.MaxValue;
                while (cnt-- > 0)
                {
                    root = queue.Dequeue();
                    if (even && (root.val % 2 == 0 || root.val <= prevVal)) return false;
                    if (!even && (root.val % 2 == 1 || root.val >= prevVal)) return false;
                    prevVal = root.val;
                    if (root.left != null) queue.Enqueue(root.left);
                    if (root.right != null) queue.Enqueue(root.right);
                }
                even = !even;
            }
            return true;
        }
    }
}