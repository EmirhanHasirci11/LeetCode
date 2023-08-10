namespace NumberofEvenandOddBits
{
    internal class Solution
    {
        public int[] EvenOddBit(int n)
        {
            char[] converted = Convert.ToString(n, 2).ToCharArray();
            Array.Reverse(converted);
            int evenIndices = 0;
            int oddIndices = 0;
            for (int i = 0; i < converted.Length; i++)
            {
                if (converted[i] == '1')
                {
                    if (i % 2 == 0)
                        evenIndices++;
                    else
                        oddIndices++;
                }
            }
            return new[] { evenIndices, oddIndices };
        }
    }
}