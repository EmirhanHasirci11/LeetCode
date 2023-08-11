namespace GreatestEnglishLetterinUpperandLowerCase
{
    internal class Solution
    {
        public string GreatestLetter(string s)
        {
            for (int i = 0; i < 26; i++)
            {
                if (s.Contains((char)('Z' - i)) && s.Contains((char)('z' - i)))
                    return ((char)('Z' - i)).ToString();

            }

            return string.Empty;
        }
    }
}