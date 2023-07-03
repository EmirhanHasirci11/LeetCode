using System.Text;

namespace SortCharactersByFrequency
{
    internal class Solution
    {        
        public string FrequencySort(string s)
        {
            Dictionary<char, int> map = new();
            StringBuilder sb = new();

            for(int i=0;i<s.Length;i++)
            {
                if (map.ContainsKey(s[i]))
                    map[s[i]]++;
                else
                    map[s[i]] = 1;                
            }
            var keys = map.ToArray();

            Array.Sort(keys,(first,second)=>second.Value-first.Value);

            foreach(var key in keys)             
                sb.Append(key.Key,key.Value);    
            
            return sb.ToString();

                
            
        }
    }
}