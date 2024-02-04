namespace MinimumWindowSubstring
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinWindow("ADOBECODEBANC","ABC"));
        }
        public static string MinWindow(string s, string t)
        {
            if(t== "") return "";

            Dictionary<char, int> tMap = new();
            foreach(char c in t)            
                if (!tMap.TryAdd(c, 1))
                    tMap[c]++;

            Dictionary<char, int> window = new();

            int currentHave=0, need=tMap.Count;
            int[] res = new int[] { -1, -1 }; 
            int resLength = int.MaxValue;
            int lPointer = 0;
            for(int i=0;i<s.Length;i++)
            {
                char c = s[i];
                if (!window.TryAdd(c, 1))
                    window[c]++;
                if (tMap.ContainsKey(c) && window[c] == tMap[c])                
                    currentHave++;

                while (currentHave == need)
                {
                    if (i - lPointer + 1 < resLength)
                    {
                        res[0]=lPointer;
                        res[1]=i;
                        resLength = i - lPointer + 1;
                    }
                    window[s[lPointer]]--;
                    if (tMap.ContainsKey(s[lPointer]) && window[s[lPointer]] < tMap[s[lPointer]])
                        currentHave--;
                    lPointer++;
                }
            }
            return resLength!=int.MinValue? s.Substring(res[0], res.Length+2):"";
            
        }
    }
}