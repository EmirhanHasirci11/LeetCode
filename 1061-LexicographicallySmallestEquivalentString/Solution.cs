namespace LexicographicallySmallestEquivalentString
{
    internal class Solution
    {
        int[] par = new int[26];

        int Find(int x)
        {
            if (par[x] == -1)
                return x;
            return par[x] = Find(par[x]);
        }

        void Union(int x, int y)
        {
            x = Find(x);
            y = Find(y);

            if (x != y)
                par[Math.Max(x, y)] = Math.Min(x, y);
        }

        public string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            // initialize the array with -1
            for (int i = 0; i < 26; i++)
                par[i] = -1;

            for (int i = 0; i < s1.Length; i++)
                Union(s1[i] - 'a', s2[i] - 'a');

            char[] result = baseStr.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (char)(Find(result[i] - 'a') + 'a');
            }

            return new string(result);
        }
    }
}
