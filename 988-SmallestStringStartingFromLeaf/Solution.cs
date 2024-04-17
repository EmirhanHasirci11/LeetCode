namespace SmallestStringStartingFromLeaf
{
    internal class Solution
    {        
        public string SmallestFromLeaf(TreeNode root)
        {
            string res = "";
            public string SmallestFromLeaf(TreeNode root)
            {
                DFS(root, "");
                return res;
            }

            public void DFS(TreeNode root, string currStr)
            {
                if (root == null)
                    return;
                currStr = (char)(root.val + 'a') + currStr;
                if (root.left == null && root.right == null)
                    if (res == "" || string.Compare(res, currStr) > 0)
                        res = currStr;
                if (root.left != null)
                    DFS(root.left, currStr);
                if (root.right != null)
                    DFS(root.right, currStr);
            }
        }
    }
}
