namespace FindFirstPalindromicStringintheArray
{
    internal class Solution
    {
        public string FirstPalindrome(string[] words)
        {
            foreach(string word in words)
            {
                if (word.Reverse().SequenceEqual(word))
                    return word;
            }
            return string.Empty;
        }
    }
}