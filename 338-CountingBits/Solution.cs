namespace CountingBits
{
    internal class Solution
    {        
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            for(int i = 0; i <= n; i++)
            {
                string temp = Convert.ToString(i, 2);
                result[i] = temp.Count(x=>x=='1');
            }
            return result;
        }
    }
}