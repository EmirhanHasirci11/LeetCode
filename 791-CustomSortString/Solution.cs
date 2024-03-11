using System.Text;

namespace CustomSortString
{
    internal class Solution
    {        
        public string CustomSortString(string order, string s)
        {
            int[] count = new int[26];
            foreach (char c in s)            
                ++count[c - 'a'];  
            
            StringBuilder sb = new StringBuilder();
            foreach (char c in order)            
                while (count[c - 'a']-- > 0)                
                    sb.Append(c);  
                
            
            for (char c = 'a'; c <= 'z'; ++c)            
                while (count[c - 'a']-- > 0)                
                    sb.Append(c); 
                            
            return sb.ToString();
        }
    }
}