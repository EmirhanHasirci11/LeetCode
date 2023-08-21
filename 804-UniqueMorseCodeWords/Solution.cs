using System.Text;

namespace UniqueMorseCodeWords
{
    internal class Solution
    {        
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] mors = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            Dictionary<string,int>map= new ();
            foreach(string word in words)
            {
                StringBuilder sb= new StringBuilder();
                foreach(char c in word)
                {
                    sb.Append(mors[c-'a']);
                }
                if(!map.TryAdd(sb.ToString(),1))
                    map[sb.ToString()]++;
            }
            return map.Count();

        }
    }
}