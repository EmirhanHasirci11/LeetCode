namespace NumberOfLinesToWriteString
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            int[] widths = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }; 
            var s = "abcdefghijklmnopqrstuvwxyz";
            var result=NumberOfLines(widths, s);
            foreach( var res in result ) 
            {
                Console.WriteLine(res);
            }

        }
        public static int[] NumberOfLines(int[] widths, string s)
        {
            int countOfLines = 0;
            int totalWide = 0;
            for (int i = 0; i < s.Length; i++)
            {
                totalWide += widths[s[i] - 'a'];
                if (totalWide > 100)
                {
                    totalWide = 0;
                    countOfLines++;
                    totalWide += widths[s[i] - 'a'];
                }
            }
            return new int[] { ++countOfLines, totalWide };
        }
    }
}