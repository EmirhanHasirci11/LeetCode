namespace CheckifaParenthesesStringCanBeValid
{
    internal class Solution
    {
        public bool CanBeValid(string s, string locked)
        {
            int stringLength = s.Length;
            if (stringLength % 2 == 1)
            {
                return false;
            }

            Stack<int> openIndices = new Stack<int>();
            Stack<int> unlockedIndices = new Stack<int>();

            for (int i = 0; i < stringLength; i++)
            {
                if (locked[i] == '0')
                {
                    unlockedIndices.Push(i);
                }
                else if (s[i] == '(')
                {
                    openIndices.Push(i);
                }
                else if (s[i] == ')')
                {
                    if (openIndices.Count > 0)
                    {
                        openIndices.Pop();
                    }
                    else if (unlockedIndices.Count > 0)
                    {
                        unlockedIndices.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            while (openIndices.Count > 0 && unlockedIndices.Count > 0 &&
                   openIndices.Peek() < unlockedIndices.Peek())
            {
                openIndices.Pop();
                unlockedIndices.Pop();
            }

            // If there are unmatched '(' and enough unlocked positions left,
            // ensure the total count is even for a valid match.
            return openIndices.Count == 0 && unlockedIndices.Count % 2 == 0;
        }
    }
}
