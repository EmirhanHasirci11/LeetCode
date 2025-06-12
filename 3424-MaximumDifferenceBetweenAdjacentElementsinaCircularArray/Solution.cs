namespace MaximumDifferenceBetweenAdjacentElementsinaCircularArray
{
    internal class Solution
    {
        public int MaxAdjacentDistance(int[] nums)
        {
            int maxDistance = 0;
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                int next = (i + 1) % n; // wrap around for circular adjacency
                int diff = Math.Abs(nums[i] - nums[next]);
                maxDistance = Math.Max(maxDistance, diff);
            }

            return maxDistance;
        }
    }
}
