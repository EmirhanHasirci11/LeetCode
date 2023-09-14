namespace DivideArrayIntoEqualPairs
{
    internal class Solution
    {        
        public bool DivideArray(int[] nums)
        {
            if (nums.Length % 2 != 0) return false;
            Dictionary<int, int> map = new();
            foreach(int num in nums)
            {
                if (!map.TryAdd(num, 1))
                    map[num]++;
            }
            foreach(int pairs in map.Values)
                if (pairs % 2!=0)
                    return false;
            return true;
        }
    }
}