namespace Subsets
{
    internal class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            backtrack(result, new List<int>(), nums, 0);
            return result;
        }

        void backtrack(List<IList<int>> result, List<int> sub, int[] nums, int start)
        {
            result.Add(new List<int>(sub));
            for (int i = start; i < nums.Length; i++)
            {
                sub.Add(nums[i]);
                backtrack(result, sub, nums, i + 1);
                sub.RemoveAt(sub.Count - 1);
            }
        }
    }
}