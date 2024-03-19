namespace TaskScheduler
{
    internal class Solution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            int[] freq = new int[26];
            int max = 0;
            int maxCount = 0;
            foreach (char task in tasks)
            {
                freq[task - 'A']++;
                if (max == freq[task - 'A'])
                {
                    maxCount++;
                }
                else if (max < freq[task - 'A'])
                {
                    max = freq[task - 'A'];
                    maxCount = 1;
                }
            }

            int gapCount = max - 1;
            int gapLength = n - (maxCount - 1);
            int empty = gapCount * gapLength;
            int availableTasks = tasks.Length - max * maxCount;
            int idles = Math.Max(0, empty - availableTasks);

            return tasks.Length + idles;
        }
    }
}
