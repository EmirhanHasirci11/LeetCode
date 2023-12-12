using System.Text;

namespace MaximumValueofaStringinanArray
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaximumValue(new string[] { "iw1", "61939", "7", "7i", "cye", "bv7yg", "t3ye6", "990" }));
        }
        public static int MaximumValue(string[] strs)
        {
            string word;
            bool isLetter; ;
            int maxLength = int.MinValue;
            for (int i = 0; i < strs.Length; i++)
            {
                isLetter = false;
                word = strs[i];
                foreach (char c in word)
                    if (char.IsLetter(c))
                    {
                        isLetter = true;
                        break;
                    }

                if (isLetter)
                {
                    maxLength = Math.Max(maxLength, word.Length);
                    continue;
                }
                maxLength = Math.Max(maxLength, Convert.ToInt32(word));
            }
            return maxLength;
        }
    }
}