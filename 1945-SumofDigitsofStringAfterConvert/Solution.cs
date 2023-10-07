namespace SumofDigitsofStringAfterConvert
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            GetLucky("iiii",1);
        }
        public static int GetLucky(string s, int k)
        {
            string res = string.Empty;
            foreach(char c in s)            
                res += c - 'a' + 1;
            
            while (k > 0)
            {
                int sumOfDigits = 0;
                for(int i=0;i<res.Length;i++)
                {
                    sumOfDigits += (int)char.GetNumericValue(res[i]);
                }
                res = sumOfDigits.ToString();
                k--;
                
            }
            return Convert.ToInt32(res);

        }
    }
}