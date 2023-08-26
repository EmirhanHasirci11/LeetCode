namespace NumberofBeautifulPairs
{
    internal class Solution
    {
        public int CountBeautifulPairs(int[] nums)
        {
            int countOfBeautifulPairs = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                int remaining = nums[i]%10;
                for(int j=0;j<i; j++) 
                {
                    int n = nums[j];
                    while (n >= 10)
                    {
                        n /= 10;
                    }
                    countOfBeautifulPairs += GCD(n, remaining) == 1 ? 1 : 0;
                }
            }
            return countOfBeautifulPairs;
        }
        public int GCD(int a, int b)
        {
            if (b > a)
                GCD(b, a);
            if (a % b == 0)
                return b;
            return GCD(b, a % b);
        }
    }
}