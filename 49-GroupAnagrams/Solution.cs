namespace GroupAnagrams
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> map = new();
            foreach (string s in strs)
            {
                char[] cArr = s.ToCharArray();
                Array.Sort(cArr);
                string sorted = new string(cArr);
                if (!map.TryAdd(sorted, new List<string>() { s }))
                    map[sorted].Add(s);
            }
            IList<IList<string>> list = map.Values.ToList();
            return list;

        }
    }
}