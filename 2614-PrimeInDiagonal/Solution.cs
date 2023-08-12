namespace PrimeInDiagonal
{
    internal class Solution
    {
        public int DiagonalPrime(int[][] nums)
        {
            int max = 0;
            int lenghtOfNums =nums.Length;
            for(int i =0;i<lenghtOfNums;i++)
            {
                if (IsPrime(nums[i][i]))
                    max = max > nums[i][i]?max: nums[i][i];
                if (IsPrime(nums[i][lenghtOfNums - 1 - i]))
                    max = max > nums[i][lenghtOfNums - 1 - i] ? max : nums[i][lenghtOfNums - 1 - i];
            }
            return max;
        }
        public bool IsPrime(int x)
        {
            if (x == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
    }
}