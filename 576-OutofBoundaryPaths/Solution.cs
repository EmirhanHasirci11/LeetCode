﻿namespace OutofBoundaryPaths
{
    internal class Solution
    {
        public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
        {
            const int M = 1000000007;
            int count = 0;
            int[,] dp = new int[m, n];
            dp[startRow, startColumn] = 1;
            for (int moves = 1; moves <= maxMove; moves++)
            {
                int[,] temp = new int[m, n];

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == m - 1) count = (count + dp[i, j]) % M;
                        if (j == n - 1) count = (count + dp[i, j]) % M;
                        if (i == 0) count = (count + dp[i, j]) % M;
                        if (j == 0) count = (count + dp[i, j]) % M;
                        temp[i, j] = (
                                ((i > 0 ? dp[i - 1, j] : 0) + (i < m - 1 ? dp[i + 1, j] : 0)) % M +
                                ((j > 0 ? dp[i, j - 1] : 0) + (j < n - 1 ? dp[i, j + 1] : 0)) % M
                        ) % M;
                    }
                }
                dp = temp;
            }
            return count;
        }
    }
}