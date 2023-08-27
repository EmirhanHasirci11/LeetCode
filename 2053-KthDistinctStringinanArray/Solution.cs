namespace KthDistinctStringinanArray
{
    internal class Solution
    {        
        public  string KthDistinct(string[] arr, int k)
        {
            Dictionary<string, int> map = new();
            foreach (string c in arr)
            {
                if(!map.TryAdd(c,1))
                    map[c]++;
            }

            int count = 0;

            foreach(string c in map.Keys)
            {
                if (map[c] == 1)
                    count++;
                if(count==k)
                    return c;
            }
            return string.Empty;
            
        }
    }
}