namespace FindIndicesWithIndexandValueDifferenceI
{
    internal class Solution
    {        
        public int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length; j++)
                    if (Math.Abs(i - j) >= indexDifference && Math.Abs(nums[i] - nums[j]) >= valueDifference)
                        return new int[] { i, j };
            return new int[] { -1, -1 };
        }
    }
}