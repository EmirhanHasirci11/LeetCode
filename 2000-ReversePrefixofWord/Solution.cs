using System.Text;

namespace ReversePrefixofWord
{
    internal class Solution
    {
        public string ReversePrefix(string word, char ch)
        {
            if (!word.Contains(ch))
                return word;
            string result = "";
            foreach (char c in word)
            {
                result = c + result;
                if (c == ch)
                    break;
            }

            
            return result + word.Substring(result.Length);
        }
    }
}