namespace ThirdMaximumNumber
{
    internal class Solution
    {
        public int ThirdMax(int[] nums)
        {
            HashSet<int> set = new();
            foreach (int num in nums)
            {
                set.Add(num);
                if (set.Count > 3) set.Remove(set.Min());
            }
            if (set.Count < 3) return set.Max();
            return set.Min();
        }
    }
}