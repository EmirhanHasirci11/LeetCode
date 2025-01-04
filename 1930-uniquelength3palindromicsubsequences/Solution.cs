namespace uniquelength3palindromicsubsequences
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public int CountPalindromicSubsequence(string s)
        {
            int[] R = new int[26];  // Right count for characters
            int[] L = new int[26];  // Left count for characters
            HashSet<int> S = new HashSet<int>();  // Set to store unique subsequences
            int result = 0;

            foreach (char c in s)
            {
                R[c - 'a']++;
            }

            // Traverse the string and find valid palindromic subsequences
            foreach (char c in s)
            {
                int t = c - 'a';
                R[t]--;
                for (int j = 0; j < 26; j++)
                {
                    if (L[j] > 0 && R[j] > 0)
                    {
                        S.Add(26 * t + j);
                    }
                }

                L[t]++;
            }

            // The size of the set gives the number of unique palindromic subsequences
            return S.Count;
        }
    }
}
