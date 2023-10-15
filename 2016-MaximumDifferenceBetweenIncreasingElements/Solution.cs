namespace MaximumDifferenceBetweenIncreasingElements
{
    internal class Solution
    {        
        public int MaximumDifference(int[] nums)
        {
            int maximumDifferecenBetweenNumbers = -1;
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = i + 1; j < nums.Length;j++)
                {
                    if (nums[i] < nums[j])
                        maximumDifferecenBetweenNumbers = nums[j] - nums[i] > maximumDifferecenBetweenNumbers ? nums[j] - nums[i] : maximumDifferecenBetweenNumbers;

                }
            } 
                
                
            
            return maximumDifferecenBetweenNumbers;
        }
    }
}