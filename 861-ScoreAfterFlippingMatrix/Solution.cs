namespace ScoreAfterFlippingMatrix
{
    internal class Solution
    {
        public int MatrixScore(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length, score = m;
            for (int c = 1; c < n; c++)
            {
                int count = 0;
                for (int r = 0; r < m; r++)
                {
                    var row = grid[r];
                    count += 1 ^ row[0] ^ row[c];
                }
                score = (score << 1) + Math.Max(count, m - count);
            }
            return score;
        }
    }
}
