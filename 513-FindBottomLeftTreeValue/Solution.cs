namespace FindBottomLeftTreeValue
{
    internal class Solution
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            int max = 0;
            while (queue.Count != 0)
            {
                root= queue.Dequeue();
                if(root.right!=null)
                    queue.Enqueue(root.right);
                if (root.left != null)
                    queue.Enqueue(root.left);
            }
            return root.Value;
        }
    }
}