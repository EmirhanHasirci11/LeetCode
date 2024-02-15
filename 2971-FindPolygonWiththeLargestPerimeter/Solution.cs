namespace FindPolygonWiththeLargestPerimeter
{
    internal class Solution
    {
        public long LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            long res = -1;
            long total = 0;
            foreach (int i in nums)
            {
                if (total > i)
                    res = total + i;
                total += i;
            }
            return res;
        }
    }
}