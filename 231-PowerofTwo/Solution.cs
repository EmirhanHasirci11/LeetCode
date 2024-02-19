namespace PowerofTwo
{
    internal class Solution
    {        
        public bool IsPowerOfTwo(int n)
        {
            return (n > 0 && (((1 << 30) % n) == 0));
        }
    }
}