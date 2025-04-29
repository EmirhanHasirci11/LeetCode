namespace ReverseVowelsofaString
{
    internal class Solution
    {
        public string ReverseVowels(string s)
        {
            char[] word = s.ToCharArray();
            int start = 0;
            int end = s.Length - 1;
            string vowels = "aeiouAEIOU";

            while (start < end)
            {
                while (start < end && !vowels.Contains(word[start].ToString()))
                {
                    start++;
                }
                while (start < end && !vowels.Contains(word[end].ToString()))
                {
                    end--;
                }

                char temp = word[start];
                word[start] = word[end];
                word[end] = temp;

                start++;
                end--;
            }

            return new string(word);
        }
    }
}
