namespace LargestPositiveIntegerThatExistsWithItsNegative
{
    internal class Solution
    {
        public int FindMaxK(int[] nums)
        {
            nums = nums.OrderByDescending(x => x).ToArray();
            int i = 0, j = nums.Length - 1;
            while (i < j)
            {
                if (nums[i] == -1 * nums[j])
                    return nums[i];

                else if (nums[i] > -1 * nums[j])
                    i++;

                else
                    j--;
            }
            return -1;
        }
    }
}