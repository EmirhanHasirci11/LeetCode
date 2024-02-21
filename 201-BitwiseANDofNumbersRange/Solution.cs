namespace BitwiseANDofNumbersRange
{
    internal class Solution
    {
        public int RangeBitwiseAnd(int left, int right)
        {
            while (right > left) right &= right - 1;
            return right;
        }
    }
}