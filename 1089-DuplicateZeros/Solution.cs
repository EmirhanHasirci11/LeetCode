namespace DuplicateZeros
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            DuplicateZeros(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 });
        }
        static public void DuplicateZeros(int[] arr)
        {
            int i = 0, sh = 0;
            for (i = 0; sh + i < arr.Length; ++i) 
                sh += arr[i] == 0 ? 1 : 0;
            for (i = i - 1; sh > 0; --i)
            {
                if (i + sh < arr.Length) 
                    arr[i + sh] = arr[i];

                if (arr[i] == 0) 
                    arr[i + --sh] = arr[i];
            }
        }
    }
}
