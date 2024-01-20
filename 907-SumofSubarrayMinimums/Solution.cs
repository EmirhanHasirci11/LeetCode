namespace SumofSubarrayMinimums
{
    internal class Solution
    {
        public int SumSubarrayMins(int[] arr)
        {
            long sum = 0;
            Stack<int> stack = new();
            for (int i = 0; i <= arr.Length; i++)
            {
                while (stack.Count > 0 && arr[stack.Peek()] > (i == arr.Length ? Int32.MinValue : arr[i]))
                {

                    int mid = stack.Pop();
                    int left = stack.Count == 0 ? -1 : stack.Peek();
                    int right = i;
                    sum += (long)(arr[mid]) * (mid - left) * (right - mid);
                }
                stack.Push(i);
            }

            return (int)(sum % 1000000007);
        }
    }
}