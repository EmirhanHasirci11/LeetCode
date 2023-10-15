namespace SquaresofaSortedArray
{
    internal class Solution
    {        
        public int[] SortedSquares(int[] nums)
        {
            int lengthOfNums = nums.Length;
            int[] result = new int[lengthOfNums];
            int left = 0;
            int right = lengthOfNums - 1;
            for(int i= lengthOfNums - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    result[i] = nums[left] * nums[left];
                    left++;
                }
                else
                {
                    result[i] = nums[right] * nums[right];
                    right--;
                }
            }
            return result;

        }
    }
}