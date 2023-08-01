namespace ValidPalindrome
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal -- Panama"));

        }
        public static bool IsPalindrome(string s)
        {
            var fixedString = s.ToLower().Where(x=>char.IsLetterOrDigit(x));            
            return fixedString.Reverse().SequenceEqual(fixedString);

        }
    }
}