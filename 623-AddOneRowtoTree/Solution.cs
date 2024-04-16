namespace AddOneRowtoTree
{
    internal class Solution
    {
        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 0 || depth == 1)
            {
                TreeNode newroot = new TreeNode(v);
                newroot.left = depth == 1 ? root : null;
                newroot.right = depth == 0 ? root : null;
                return newroot;
            }
            if (root != null && depth >= 2)
            {
                root.left = AddOneRow(root.left, val, depth > 2 ? depth - 1 : 1);
                root.right = AddOneRow(root.right, val, depth > 2 ? depth - 1 : 0);
            }
            return root;
        }
    }
}
