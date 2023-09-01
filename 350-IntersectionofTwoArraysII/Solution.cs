namespace IntersectionofTwoArraysII
{
    internal class Solution
    {        
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int,int> map = new();
            foreach(int i in nums1)
            {
                if (!map.TryAdd(i, 1))
                    map[i]++;
            }
            List<int> list = new();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (map.ContainsKey(nums2[i]) && map[nums2[i]] > 0)
                {
                    map[nums2[i]]--;
                    list.Add(nums2[i]);
                }

            }

            return list.ToArray();


        }
    }
}