namespace CounttheNumberofConsistentStrings
{
    internal class Solution
    {       
        public int CountConsistentStrings(string allowed, string[] words)
        {
            HashSet<char> set = new(allowed);
            int result = 0;
            foreach (string word in words)
            {
                bool incremant = true;
                for (int i = 0; i < word.Length; i++)
                {

                    if (!set.Contains(word[i]))
                        incremant = false;
                }
                if (incremant == true)
                    result++;

            }
            return result;

        }
    }
}