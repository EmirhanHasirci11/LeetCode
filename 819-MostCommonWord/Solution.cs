using System.Text;

namespace MostCommonWord
{
    internal class Solution
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            StringBuilder sb = new();
            string res=string.Empty;
            int count = 0;
            foreach (char c in paragraph)
            {
                if (char.IsPunctuation(c))
                    sb.Append(" ");
                else
                    sb.Append(char.ToLower(c));
            }
            Dictionary<string, int> map = new();
            string[] words = sb.ToString().Split(" ");
            foreach (string str in words)
            {
                if (str == "") continue;
                if (banned.Contains(str)) continue;
                if (map.ContainsKey(str))
                    map[str]++;
                else
                    map[str] = 1;
                if (map[str] > count)
                {
                    count = map[str];
                    res = str;
                }
            }
            return res;

        }
    }
}