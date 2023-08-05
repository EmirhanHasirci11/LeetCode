namespace FindtheMaximumDivisibilityScore
{
    internal class Solution
    {
        public int MaxDivScore(int[] nums, int[] divisors)
        {
            int maxDivisor = divisors.Min();
            int resultDivisorCount = 0;
            foreach(int divisor in divisors)
            {
                int totalCount = 0;
                for(int i=0;i<nums.Length;i++)
                {
                    if (nums[i] % divisor == 0)
                        totalCount++;
                }
                if(totalCount>resultDivisorCount || (totalCount==resultDivisorCount && divisor < maxDivisor))
                {
                    maxDivisor= divisor;
                    resultDivisorCount= totalCount;
                }
            }
                return maxDivisor;
        }
    }
}