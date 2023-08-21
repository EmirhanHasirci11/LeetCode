using System.Text;

namespace RepeatedSubstringPattern
{
    internal class Solution
    {       
        public bool RepeatedSubstringPattern(string s)
        {
            int lengthOfS = s.Length;
            for (int i = 1; i <= lengthOfS / 2; i++)
            {
                if (lengthOfS % i == 0)
                {
                    string substr = s.Substring(0, i);
                    StringBuilder sb = new();
                    for (int j = 0; j < lengthOfS / i; j++)
                        sb.Append(substr);
                    if (sb.ToString() == s)
                        return true;
                }
            }
            return false;
        }
    }
}