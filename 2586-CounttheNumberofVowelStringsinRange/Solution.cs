namespace CounttheNumberofVowelStringsinRange
{
    internal class Solution
    {        
        public int VowelStrings(string[] words, int left, int right)
        {
            char[] vowels = new[] { 'a', 'e', 'i', 'o','u' };
            int countOfVowelString = 0;
            while (left <= right)
            {
                if (vowels.Contains(words[left][0]) && vowels.Contains(words[left][words[left].Length - 1]))
                    countOfVowelString++;
                left++;
            }
            return countOfVowelString;
        }
    }
}