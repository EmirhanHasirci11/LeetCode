namespace BinaryPrefixDivisibleBy5
{
    internal class Solution
    {        
        public IList<bool> PrefixesDivBy5(int[] nums)
        {
            int x = 0;
            bool[] res= new bool[nums.Length];
            int index = 0;
            while (index < nums.Length)
            {
                x = (x * 2 + nums[index]) % 10;
                res[index] = (x%5==0);
                index++;
            }
            return res;
        }
    }
}