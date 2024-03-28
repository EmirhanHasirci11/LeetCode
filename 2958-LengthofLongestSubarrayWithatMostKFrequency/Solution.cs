namespace LengthofLongestSubarrayWithatMostKFrequency
{
    internal class Solution
    {       
        public int MaxSubarrayLength(int[] nums, int k)
        {
            int i = 0;
            int j = 0;
            int n = nums.Length;
            int ans = 1;
            Dictionary<int, int> map = new Dictionary<int, int>();

            while (i < n)
            {
                if (map.ContainsKey(nums[i]))
                    map[nums[i]]++;
                else
                    map[nums[i]] = 1;

                while (map[nums[i]] > k)
                {
                    map[nums[j]]--;
                    j++;
                }
                ans = System.Math.Max(ans, i - j + 1);
                i++;
            }
            return ans;
        }
    }
}
