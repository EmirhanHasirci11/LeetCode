namespace AddDigits
{
    internal class Solution
    {        
        public static int AddDigits(int num)
        {
            while (num % 10 != num)
            {
            int temp =0;
                
                while (num != 0)
                {
                    temp+=num % 10;
                    num /= 10;
                }
                num = temp;
            }
            return num;
        }
    }
}