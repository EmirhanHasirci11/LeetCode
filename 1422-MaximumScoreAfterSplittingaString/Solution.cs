namespace MaximumScoreAfterSplittingaString
{

    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxScore("1111"));
        }
        
        static public int MaxScore(string s)
        {
            int maxScore = int.MinValue;
            for (int i = 0; i + 1 < s.Length; i++)
            {
                string left=s.Substring(0,i==s.Length?i:i+1);
                string right=s.Substring(i==s.Length?i:i+1,s.Length-i-1);
                maxScore = (int)Math.Max(maxScore, left.Where(x=>x=='0').Count()+right.Where(x=>x=='1').Count());
            }
            return maxScore;
        }
    }
}
