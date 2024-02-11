namespace CherryPickupII
{
    public class Solution
    {
        static void Main(string[] args)
        {
            CherryPickup(new int[][] {new int[] { 3, 1, 1 }, new int[] { 2, 5, 1 }, new int[] { 1, 5, 5 }, new int[] { 2, 1, 1 } });
        }
        public static int CherryPickup(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;

            int[][][] dp = new int[n][][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new int[m][];
                for (int j = 0; j < m; j++)
                {
                    dp[i][j] = new int[m];
                    for (int k = 0; k < m; k++)
                    {
                        dp[i][j][k] = -1;
                    }
                }
            }

            return DFS(grid, n, m, 0, 0, m - 1, dp);
        }

        private static int DFS(int[][] grid, int n, int m, int r, int col1, int col2, int[][][] dp)
        {
            if (r < 0 || r >= n || col1 < 0 || col1 >= m || col2 < 0 || col2 >= m)
            {
                return 0;
            }

            if (dp[r][col1][col2] != -1)
            {
                return dp[r][col1][col2];
            }

            int maxCherries = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newCol1 = col1 + i;
                    int newCol2 = col2 + j;

                    maxCherries = Math.Max(maxCherries, DFS(grid, n, m, r + 1, newCol1, newCol2, dp));
                }
            }

            int currCherry = (col1 == col2) ? grid[r][col1] : grid[r][col1] + grid[r][col2];

            dp[r][col1][col2] = currCherry + maxCherries;
            return dp[r][col1][col2];
        }
    }
}