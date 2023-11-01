namespace LargesTthree_Same_DigitNumberinString
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestGoodInteger("6777133339"));
        }
        public static string LargestGoodInteger(string num)
        {
            char c = num[0];
            int countOfSubstring = 1;
            int largestGoodInteger = 0;
            for(int i=1;i<num.Length;i++)
            {
                if (c == num[i])
                {
                    countOfSubstring++;
                }
                else
                {
                    countOfSubstring=1;
                }
                if (countOfSubstring == 3)
                {
                    largestGoodInteger = Math.Max(largestGoodInteger, num[i]);
                }
                c= num[i];
            }
            return new string((char)largestGoodInteger, 3);
        }
    }
}