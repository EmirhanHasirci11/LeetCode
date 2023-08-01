namespace XOROperationinanArray
{
    internal class Program
    {
        public int XorOperation(int n, int start)
        {
            int xorSum = start;

            for (int i = 1; i < n; i++)
                xorSum ^= start + (2 * i);

            return xorSum;
        }
    }
}