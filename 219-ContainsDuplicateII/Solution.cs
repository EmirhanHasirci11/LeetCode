namespace ContainsDuplicateII
{
    internal class Solution
    {        
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> map = new();
            for(int i=0;i<nums.Length;i++)
            {
                if (map.ContainsKey(nums[i]) && Math.Abs(map[nums[i]] - i) <= k)
                    return true;
                map[nums[i]] = i;
            }
            return false;
        }
    }
}