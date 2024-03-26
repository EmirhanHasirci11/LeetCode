namespace FirstMissingPositive
{
    internal class Solution
    {        
        public int FirstMissingPositive(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    j++;
                }
            }           
            for (int i = j; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]);
                if (index > 0 && index <= nums.Length - j)
                {
                    nums[j + index - 1] = -Math.Abs(nums[j + index - 1]);
                }
            }

            for (int i = j; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    return i - j + 1;
                }
            }
           
            return nums.Length - j + 1;
        }
    }
}
