namespace LargestLocalValuesinaMatrix
{
    internal class Solution
    {
      
        public int[][] LargestLocal(int[][] grid)
        {
            int n = grid.Length;
            var res = new int[n - 2][];
            for (int i = 0; i < n - 2; i++)
            {
                res[i] = new int[n - 2];
                for (int j = 0; j < n - 2; j++)
                {
                    for (int ii = i; ii < i + 3; ii++)
                    {
                        for (int jj = j; jj < j + 3; jj++)
                        {
                            res[i][j] = Math.Max(res[i][j], grid[ii][jj]);
                        }
                    }
                }
            }
            return res;
        }
    }
}
