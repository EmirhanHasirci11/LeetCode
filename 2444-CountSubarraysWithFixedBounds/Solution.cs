namespace CountSubarraysWithFixedBounds
{
    internal class Solution
    {        
        public long CountSubarrays(int[] nums, int minK, int maxK)
        {
            long res = 0;
            int badIdx = -1, leftIdx = -1, rightIdx = -1;

            for (int i = 0; i < nums.Length; ++i)
            {
                if (!(minK <= nums[i] && nums[i] <= maxK))
                {
                    badIdx = i;
                }

                if (nums[i] == minK)
                {
                    leftIdx = i;
                }

                if (nums[i] == maxK)
                {
                    rightIdx = i;
                }

                res += Math.Max(0, Math.Min(leftIdx, rightIdx) - badIdx);
            }

            return res;
        }
    }
}
