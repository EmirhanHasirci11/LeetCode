namespace MaximumNumberofPairsinArray
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            
        }
        public int[] NumberOfPairs(int[] nums)
        {
            int countOfPairs = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == -1)
                    continue;
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] == nums[j]) && (nums[i] != 0 && nums[j]!=0))
                    {
                        countOfPairs++;
                        nums[i] = -1;
                        nums[j] = -1;
                        break;
                    }
                }
            }
            int countOfLeftovers = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i]!=-1)
                    countOfLeftovers++;
            }
            return new int[] {countOfPairs,countOfLeftovers};
        }
    }
}