namespace FibonacciNumber
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(4));
        }
        public static int Fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return Fib(n - 1) + Fib(n - 2);

        }
    }
}