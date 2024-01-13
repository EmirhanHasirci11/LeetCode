namespace MinimumNumberofStepstoMakeTwoStringsAnagram
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public int MinSteps(string s, string t)
        {
            int[] sA = new int[26];
            int[] tA = new int[26];
            for(int i = 0; i < s.Length; i++)
            {
                sA[s[i]-'a']++;
                tA[t[i]-'a']++;
            }
            int step = 0;
            for (int i = 0; i < 26; i++)
                step += Math.Abs(sA[i] - tA[i]);
            return step/2;
        }
    }
}