namespace LargestDivisibleSubset
{
    internal class Solution
    {
        List<int> res;
        int[] dp;

        public List<int> LargestDivisibleSubset(int[] nums)
        {
            Array.Sort(nums);
            res = new List<int>();
            dp = new int[nums.Length];
            Array.Fill(dp, -1);
            Dfs(nums, 0, new List<int>(), 1);
            return res;
        }

        private void Dfs(int[] nums, int index, List<int> curr, int prev)
        {
            if (curr.Count > res.Count)            
                res = new List<int>(curr);
            

            for (int i = index; i < nums.Length; i++)            
                if (curr.Count > dp[i] && nums[i] % prev == 0)
                {
                    dp[i] = curr.Count;
                    curr.Add(nums[i]);
                    Dfs(nums, i + 1, curr, nums[i]);
                    curr.RemoveAt(curr.Count - 1);
                }
            
        }
    }
}