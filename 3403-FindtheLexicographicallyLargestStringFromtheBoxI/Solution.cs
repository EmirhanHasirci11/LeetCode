namespace FindtheLexicographicallyLargestStringFromtheBoxI
{
    internal class Solution
    {
        public string AnswerString(string word, int numFriends)
        {
            if (numFriends == 1)
                return word;
            int n = word.Length, i, end;
            int split_length = n - numFriends;
            string m = "", cur = "";
            for (i = 0; i < n; i++)
            {
                end = split_length;
                if (i + end > n - 1)                
                    end = n - i - 1;                
                cur = word.Substring(i, end + 1);
                if (String.Compare(cur, m) > 0)                
                    m = cur;                
            }
            return m;
        }
    }
}
