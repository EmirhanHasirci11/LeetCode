﻿namespace MinimumFallingPathSum
{
    internal class Solution
    {        
        public int MinFallingPathSum(int[][] matrix)
        {
            for (int i = 1; i < matrix.Length; ++i)
                for (int j = 0; j < matrix.Length; ++j)
                    matrix[i][j] += Math.Min(matrix[i - 1][j], Math.Min(matrix[i - 1][Math.Max(0, j - 1)], matrix[i - 1][Math.Min(matrix.Length- 1, j + 1)]));
            return matrix[matrix.Length- 1].Min();
        }
    }
}