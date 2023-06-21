namespace Numberof1Bits
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HammingWeight(00000000000000000000000000001011));
        }
        public static int HammingWeight(uint n)
        {
            uint result = 0;
            while (n > 0)
            {
                result += n % 2;
                n = n >> 1;
            }
            return (int)result;

        }
    }
}