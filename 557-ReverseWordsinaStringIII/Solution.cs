using System.Text;

namespace ReverseWordsinaStringIII
{
    internal class Solution
    {        
        public string ReverseWords(string s)
        {
            string[] arrayOfS = s.Split();
            StringBuilder sb = new();
            foreach(string word in arrayOfS)
            {
                for(int i = word.Length - 1; i >= 0; i--)                
                    sb.Append(word[i]);
                
                sb.Append(" ");
            }
            return sb.ToString().Trim();
        }
    }
}