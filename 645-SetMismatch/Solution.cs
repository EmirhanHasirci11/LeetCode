namespace SetMismatch
{
    internal class Solution
    {
        public int[] FindErrorNums(int[] nums)
        {
            int duplicate = 0;
            int misVal = 0;
            HashSet<int> set = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.TryGetValue(nums[i], out int b))
                    duplicate = nums[i];
                set.Add(nums[i]);
            }
            for(int i = 1; i <= nums.Length; i++)
            {
                if (!set.Contains(i))
                {
                    misVal= i;
                    break;
                }
            }

            return new int[] {duplicate,misVal};
        }
    }
}