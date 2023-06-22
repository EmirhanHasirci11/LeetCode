namespace MajorityElement
{
    internal class Program
    {       
        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> map = new();
            foreach(int num in nums)
            {
                if (map.ContainsKey(num))                
                    map[num]++;                
                else
                    map[num] = 1;                                
            }
            foreach(var key in map.Keys)
            {
                if (map[key] > nums.Length / 2)
                    return key;
            }
            return 0;
        }
    }
}