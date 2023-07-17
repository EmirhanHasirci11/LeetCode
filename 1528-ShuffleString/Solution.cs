using System.Text;

namespace ShuffleString
{
    internal class Solution
    {
        public string RestoreString(string s, int[] indices)
        {
            StringBuilder sb = new StringBuilder(s);

            for (int i = 0; i < s.Length; i++)
                sb[indices[i]] = s[i];

            return sb.ToString();
        }
    }
}