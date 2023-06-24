namespace SmallestIndexWithEqualValue
{
    internal class Solution
    {
        public int SmallestEqual(int[] nums)
        {
            int smallest = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 10 == nums[i])
                {
                    if (i < smallest)
                        smallest = i;
                }
            }
            return smallest < nums.Length ? smallest : -1;
        }
    }
}