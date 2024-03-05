namespace MinimumLengthofStringAfterDeletingSimilarEnds
{
    internal class Solution
    {
        public int MinimumLength(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i < j && s[i] == s[j])
            {
                char c = s[j];
                while (i <= j && s[i] == c)
                {
                    ++i;
                }
                while (i <= j && s[j] == c)
                {
                    --j;
                }
            }
            return j - i + 1;
        }
    }
}