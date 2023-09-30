namespace NumberofCommonFactors
{
    internal class Solution
    {        
        public int CommonFactors(int a, int b)
        {
            int countOfCommonFactors = 1;
            int min = Math.Min(a, b);
            for (int i = 2; i <= min; i++)
                if (a % i == 0 && b % i == 0)
                    countOfCommonFactors++;

            return countOfCommonFactors;
                        

        }

    }
}