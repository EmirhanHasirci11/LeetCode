namespace ClimbingStairs
{
    internal class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            int first = 2;
            int second = 1;
            int current = 0;

            for (int i = 2; i < n; i++)
            {
                current = first + second;
                second = first;
                first = current;
            }
            return current;
        }
    }
}