using System.Text;

namespace SortingtheSentence
{
    internal class Solution
    {

        public string SortSentence(string s)
        {
            string[] words = s.Split(" ");
            string[] answerArray = new string[words.Length];
            foreach (string word in words)
            {
                answerArray[Convert.ToInt16(word.Substring(word.Length - 1)) - 1] = word.Substring(0, word.Length - 1);
            }
            StringBuilder sb = new();
            foreach (string word in answerArray)
            {
                sb.Append(word + " ");
            }
            return sb.ToString().Trim();
        }
    }
}