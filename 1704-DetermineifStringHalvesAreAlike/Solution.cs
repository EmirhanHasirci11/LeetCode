namespace DetermineifStringHalvesAreAlike
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HalvesAreAlike("book"));
        }
        public static bool HalvesAreAlike(string s)
        {
            HashSet<char> result = new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int leftVowelCount = 0;
            int rightVowelCount = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (i < Math.Floor((double)s.Length / 2))
                    leftVowelCount += result.Contains(s[i]) ? 1 : 0;
                else
                    rightVowelCount += result.Contains(s[i]) ? 1 : 0;
            }
            return leftVowelCount == rightVowelCount;
        }
    }
}