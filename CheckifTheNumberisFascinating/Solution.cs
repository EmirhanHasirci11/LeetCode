namespace CheckifTheNumberisFascinating
{
    internal class Solution
    {     
        public bool IsFascinating(int n)
        {
            Dictionary<char, int> map = new();
            string number = ""+n + n * 2 + n * 3;            
            foreach(char c in number) 
            {
                if (c == '0') return false;
                if(map.ContainsKey(c))
                    map[c]++;
                else
                    map[c] = 1;
            }            
            for(int i='1';i<='9';i++) 
            {
                if (!map.ContainsKey((char)i)) return false;
                else if(map[(char)i] != 1) return false;                                    
            }
            return true;
        }
    }
}