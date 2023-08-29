namespace ShuffletheArray
{
    internal class Solution
    {        
        public int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[2*n];            
            int leftIndexer = 0;
            for (int i = 0; i<result.Length;i++)
            {
                if (i % 2 == 0)
                {
                    result[i] = nums[leftIndexer];
                    leftIndexer++;
                }
                else
                {
                    result[i] = nums[n];
                    n++;
                }
            }
            return result;
        }
    }
}