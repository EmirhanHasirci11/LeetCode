namespace DistributeCandiesAmongChildrenII
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public long DistributeCandies(int n, int limit)
        {
            long res =0;
            for (int i = 0; i <= Math.Min(limit, n); i++)
            {
                if (n - i <= 2 * limit)
                {
                    res += Math.Min(n - i, limit) - Math.Max(0, n - i - limit) + 1;
                }
            }
            return res;
        }   
    }
}
