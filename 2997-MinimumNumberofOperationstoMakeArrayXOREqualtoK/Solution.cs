namespace MinimumNumberofOperationstoMakeArrayXOREqualtoK
{
    internal class Solution
    {
        public int MinOperations(int[] nums, int k)
        {
            int finalXor = 0;
            foreach (int i in nums)
                finalXor ^= i;

            int count = 0;
            while (k > 0 || finalXor > 0)
            {
                if ((k % 2) != (finalXor % 2))
                    count++;
                k /= 2;
                finalXor /= 2;
            }
            return count;

        }
    }
}
