namespace AddtoArray_FormofInteger
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            AddToArrayForm(new int[] { 2, 7, 4 }, 181);
        }
        public static IList<int> AddToArrayForm(int[] num, int k)
        {
            List<int> res = new();
            for (int i = num.Length - 1; i >= 0; --i)
            {
                res.Insert(0, (num[i] + k) % 10);
                k = (num[i] + k) / 10;
            }
            while (k > 0)
            {
                res.Insert(0, k % 10);
                k /= 10;
            }
            return res;
        }
    }
}