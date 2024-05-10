namespace K_thSmallestPrimeFraction
{
    internal class Solution
    {       
        public int[] KthSmallestPrimeFraction(int[] arr, int k)
        {
            List<int[]> fractions = new List<int[]>();

            for (int i = 0; i < arr.Length - 1; i++)            
                for (int j = i + 1; j < arr.Length; j++)                
                    fractions.Add(new int[] { arr[i], arr[j] });
                            
            fractions.Sort((a, b) => a[0] * b[1] - a[1] * b[0]);

            return fractions[k - 1];
        }
    }

}
