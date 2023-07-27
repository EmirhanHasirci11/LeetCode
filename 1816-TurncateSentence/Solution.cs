using System.Text;

namespace TruncateSentence
{
    public class Solution
    {
        public string TruncateSentence(string s, int k)
        {
            StringBuilder sb = new();

            string[] words = s.Split(' ');

            for (int i = 0; i < k - 1; i++)
                sb.Append(words[i] + " ");

            sb.Append(words[k - 1]);

            return sb.ToString();
        }
    }
}