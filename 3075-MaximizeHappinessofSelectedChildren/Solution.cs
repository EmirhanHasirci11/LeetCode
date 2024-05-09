namespace MaximizeHappinessofSelectedChildren
{
    internal class Solution
    {       
        public long MaximumHappinessSum(int[] happiness, int k)
        {
            long ans = 0;
            int min = 0;

            Array.Sort(happiness);

            for (int i = happiness.Length - 1; i >= 0 && k > 0; i--)
            {

                k--;
                if (min < happiness[i])
                    ans += happiness[i] - min;
                min++;
            }
            return ans;
        }
    }
}
