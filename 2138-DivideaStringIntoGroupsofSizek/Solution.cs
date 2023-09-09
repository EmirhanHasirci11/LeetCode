using System.Text;

namespace DivideaStringIntoGroupsofSizek
{
    internal class Solution
    {        
        public string[] DivideString(string s, int k, char fill)
        {
            StringBuilder sb = new();
            List<string> list = new();
            for (int i = 1; i <= s.Length; i++)
            {
                sb.Append(s[i - 1]);
                if (i % k == 0)
                {
                    list.Add(sb.ToString());
                    sb = new StringBuilder();
                }
            }
            if (sb.Length != k && sb.Length != 0)
            {
                while (sb.Length < k)
                    sb.Append(fill);

                list.Add(sb.ToString());
            }
            return list.ToArray();
        }
    }
}