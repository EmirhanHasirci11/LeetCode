using System.Text;

namespace DecodetheMessage
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecodeMessage("the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv"));
        }
        public static string DecodeMessage(string key, string message)
        {
            HashSet<char> keys = new();
            Dictionary<char, char> decode = new();
            char alph = 'a';
            foreach (char c in key.Replace(" ",""))
            {
                if (!keys.TryGetValue(c, out char d))
                {
                    keys.Add(c);
                    decode.Add(c, alph++);
                }

            }
            StringBuilder sb = new();
            foreach (char c in message.Replace(" ", ""))
            {
                sb.Append(decode[c]);
            }
            return sb.ToString();
        }
    }
}