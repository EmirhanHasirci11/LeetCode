namespace GetMaximuminGeneratedArray
{
    internal class Solution
    {       
        public int GetMaximumGenerated(int n)
        {
            if (n == 0)
                return 0;
            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;
            int i = 1;
            while (i < arr.Length / 2)
            {
                arr[i * 2] = arr[i];
                arr[(i * 2) + 1] = arr[i] + arr[i + 1];
                i++;
            }
            return arr.Max();
        }
    }
}