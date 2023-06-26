namespace StringtoInteger_atoi_
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            string testCase = "   -4 2   ";
            Console.WriteLine(MyAtoi(testCase));
        }
        public static int MyAtoi(string s)
        {
            s=s.Trim(' ');
            string temp = "";
            for(int i =0;i<s.Length;i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    temp+= s[i];
                    continue;
                }
                if (i == 0 && s[0] == '-')
                    continue;
                if (i == 0 && s[0] == '+')
                    continue;
                break;
            }
            if (temp is "")
                return 0;
            bool cor = int.TryParse(temp, out int result);
            if (cor && s[0] == '-')
                return -result;
            if (cor)
                return result;
            
            return !cor && s[0] == '-' ? int.MinValue : int.MaxValue;



        }
    }
}