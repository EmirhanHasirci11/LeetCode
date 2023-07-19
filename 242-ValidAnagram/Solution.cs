namespace ValidAnagram
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("anagram","nagaram"));
        }
        public static bool IsAnagram(string s, string t)
        {
            Dictionary<char,int>map= new ();
            if (s.Length != t.Length)
                return false;
            
            foreach(char c in s)
            {
                if(map.ContainsKey(c))
                    map[c]++;
                else
                    map[c] = 1;
            }
            foreach(char c in t)
            {
                if (map.ContainsKey(c))
                {
                    map[c]--;

                    if (map[c] < 0)
                        return false;
                }
                else
                    return false;
            }
            return true;
        }
    }
}