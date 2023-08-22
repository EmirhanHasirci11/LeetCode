using System.Text;

namespace CheckifaStringIsanAcronymofWords
{
    internal class Solution
    {        
        public bool IsAcronym (IList<string> words, string s)
        {
            if (words.Count != s.Length)
                return false;
            for(int i=0;i<words.Count;i++)
            {
                if (!words[i].StartsWith(s[i]))
                    return false;
            }
            return true;
        }
    }
}