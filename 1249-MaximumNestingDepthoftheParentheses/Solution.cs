namespace MaximumNestingDepthoftheParentheses
{
    internal class Solution
    {        
        public int MaxDepth(string s)
        {
            int count = 0;
            int maxNum = 0;
            foreach (char c in s)
            {
                if (c == '(')
                {
                    count++;
                    if (maxNum < count)
                        maxNum = count;
                }
                else if (c == ')')
                {
                    count--;
                }
            }
            return maxNum;
        }
    }
}
