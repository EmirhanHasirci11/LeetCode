namespace BagofTokens
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BagOfTokensScore(new int[] {200,100},150));
        }
        public static int BagOfTokensScore(int[] tokens, int power)
        {
            Array.Sort(tokens);
            int left =0,right= tokens.Length-1;
            int res = 0, score = 0 ;
            while(left <= right)
            {
                if (power >= tokens[left])
                {
                    power -= tokens[left];
                    left++;
                    score++;
                    res = Math.Max(score, res);
                }
                else if (score > 0)
                {
                    power += tokens[right];
                    score--;
                    right--;

                }
                else break;
            }
            return res;
        }
    }
}