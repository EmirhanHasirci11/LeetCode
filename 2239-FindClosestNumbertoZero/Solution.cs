namespace FindClosestNumbertoZero
{
    internal class Solution
    {        
        public int FindClosestNumber(int[] nums)
        {
            int closestValue = int.MaxValue;
            int index = 0;
            foreach(int i in nums)
            {
                if (Math.Abs(i) < closestValue || i==Math.Abs(closestValue))
                {
                    closestValue = Math.Abs(i);
                    index = i;
                }
            }
            return index;
        }
    }
}