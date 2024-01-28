namespace NumberofSubmatricesThatSumtoTarget
{
    internal class Solution
    {
        public int NumSubmatrixSumTarget(int[][] A, int target)
        {
            int res = 0, m = A.Length, n = A[0].Length;
            for (int i = 0; i < m; i++)
                for (int j = 1; j < n; j++)
                    A[i][j] += A[i][j - 1];
            Dictionary<int, int> counter = new();
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    counter.Clear();
                    counter.Add(0, 1);
                    int cur = 0;
                    for (int k = 0; k < m; k++)
                    {
                        cur += A[k][j] - (i > 0 ? A[k][i - 1] : 0);
                        res += counter.GetValueOrDefault(cur - target, 0);
                        if (!counter.TryAdd(cur, counter.GetValueOrDefault(cur, 0) + 1))
                        {
                            counter[cur] = counter.GetValueOrDefault(cur, 0) + 1;
                        };
                    }
                }
            }
            return res;
        }
    }
}