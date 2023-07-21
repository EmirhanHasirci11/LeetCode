namespace KeepMultiplyingFoundValuesbyTwo
{
    internal class Solution
    {
        public int FindFinalValue(int[] nums, int original)
        {
            HashSet<int> set = nums.ToHashSet();

            while (set.Contains(original))
                original *= 2;

            return original;
        }
    }
}