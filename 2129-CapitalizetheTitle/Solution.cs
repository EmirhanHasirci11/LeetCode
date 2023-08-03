using System.Text;

namespace CapitalizetheTitle
{
    internal class Solution
    {
      
        public string CapitalizeTitle(string title)
        {
            StringBuilder sb = new();
            string[] words = title.ToLower().Split(' ');
            string lastWord = words[words.Length - 1];

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i].Length >= 3)
                    sb.Append(char.ToUpper(words[i][0]) + words[i].Substring(1) + " ");
                else
                    sb.Append(words[i] + " ");
            }

            sb.Append(lastWord.Length >= 3 ? char.ToUpper(lastWord[0]) + lastWord.Substring(1) : lastWord);

            return sb.ToString();
        }
    }
}