using System.Text;

namespace ReverseWordsinaString
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("the sky is blue"));
        }
        public static string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = s.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {

                if (words[i].Length > 0)
                {
                    sb.Append(words[i]);
                    sb.Append(' ');
                }
            }

            if (sb.Length > 0)
                sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }

    }
}
