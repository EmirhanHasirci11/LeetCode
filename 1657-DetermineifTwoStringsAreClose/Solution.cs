namespace DetermineifTwoStringsAreClose
{
    internal class Solution
    {       
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length) return false;

            int[] word1Alph = new int[26];
            int[] word2Alph = new int[26];
            for (int i = 0; i < word1.Length; i++)
            {
                word1Alph[word1[i] - 'a']++;
                word2Alph[word2[i] - 'a']++;
            }

            for (int i = 0; i < 26; i++)
                if ((word1Alph[i] == 0 && word2Alph[i] != 0) || (word1Alph[i] != 0 && word2Alph[i] == 0))
                    return false;

            Array.Sort(word1Alph);
            Array.Sort(word2Alph);

            for (int i = 0; i < 26; i++)
                if (word1Alph[i] != word2Alph[i])
                    return false;

            return true;
        }
    }
}