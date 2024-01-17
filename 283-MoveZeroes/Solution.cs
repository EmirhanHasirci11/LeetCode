namespace MoveZeroes
{
    internal class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int indexOfZero = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)                
                    indexOfZero++;                
                else if (indexOfZero > 0)
                {
                    int temp = nums[i];
                    nums[i] = 0;
                    nums[i - indexOfZero] = temp;
                }
            }
        }
    }
}