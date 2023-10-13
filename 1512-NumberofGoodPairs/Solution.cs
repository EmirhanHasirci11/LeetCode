namespace NumberofGoodPairs
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            NumIdenticalPairs(new int[] {1, 1, 1, 1});
        }
        public static int NumIdenticalPairs(int[] nums)
            {
                int countOfPairs = 0;
                for (int i = 0; i < nums.Length; i++)
                    for (int j = i + 1; j < nums.Length; j++)
                        if (nums[j] == nums[i] && i < j)
                            countOfPairs++;
                return countOfPairs;


        }
    }
}