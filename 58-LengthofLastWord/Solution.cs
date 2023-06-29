namespace LengthofLastWord
{
    internal class Solution
    {
        public int LengthOfLastWord(string s)
        {
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (Char.IsWhiteSpace(s[i]))
                {
                    if (count > 0)
                        return count;
                    continue;
                }
                count += 1;
            }
            return count;
        }
    }
}