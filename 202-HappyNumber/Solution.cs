namespace HappyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static bool IsHappy(int n)
        {
            int valueTimesValue = 0;
            int sum = 0;
            HashSet<int> set = new();
            while(n > 1)
            {
                while (n != 0)
                {
                    valueTimesValue = n % 10;
                    sum += valueTimesValue*valueTimesValue;
                    n /= 10;
                }
                if (set.Contains(sum))
                    return false;
                set.Add(sum);
                n = sum;
                sum = 0;
            }
            return true;
        }
    }
}