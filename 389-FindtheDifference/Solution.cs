namespace FindtheDifference
{
    internal class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            int sum = 0;
            foreach (char c in t)
                sum += c;
            foreach (char c in s)
                sum -= c;
            return (char)sum;
        }
    }
}