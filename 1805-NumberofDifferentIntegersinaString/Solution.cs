using System.Text;

namespace NumberofDifferentIntegersinaString
{
    internal class Solution
    {        
        public int NumDifferentIntegers(string word)
        {
            HashSet<string> h = new();

            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsDigit(word[i]))
                {
                    StringBuilder sb = new StringBuilder();
                    while (i < word.Length && Char.IsDigit(word[i]))
                    {
                        sb.Append(word[i]);
                        i++;
                    }

                    h.Add(sb.ToString().TrimStart('0'));
                }
            }

            return h.Count;
        }
    }
}