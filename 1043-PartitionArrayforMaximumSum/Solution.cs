namespace PartitionArrayforMaximumSum
{
    internal class Solution
    {        
        public int MaxSumAfterPartitioning(int[] arr, int k)
        {
            int N = arr.Length; 
            int [] dp = new int[N];
            for (int i = 0; i < N; ++i)
            {
                int curMax = 0;
                for (int j = 1; j <= k && i - j + 1 >= 0; ++j)
                {
                    curMax = Math.Max(curMax, arr[i - j + 1]);
                    dp[i] = Math.Max(dp[i], (i >= j ? dp[i - j] : 0) + curMax * j);
                }
            }
            return dp[N - 1];
        }
    }
}