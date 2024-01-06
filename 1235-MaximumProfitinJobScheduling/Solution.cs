namespace MaximumProfitinJobScheduling
{
    internal class Solution
    {
        public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            if (startTime.Length==0) return 0;
            List<Job> jobs = new();
            for (int i = 0; i < startTime.Length; i++)
                jobs.Add(new Job(startTime[i], endTime[i], profit[i]));

            jobs.Sort((a,b)=>a.StartTime-b.StartTime);
            return DFS(jobs,0,new Dictionary<int, int>);
        }
        private int DFS(List<Job> jobs,int index,Dictionary<int,int> map)
        {
            if (index >= jobs.Count)            
                return 0;            
            if (map.ContainsKey(index))            
                return map[index];

            int nextIndex=BinarySearch(jobs,index);
            int add = jobs[index].Profit + (nextIndex == -1 ? 0 : DFS(jobs, nextIndex, map));
            int notAdd=DFS(jobs, index+1, map);
            int calculatedMaxProfit= Math.Max(add,notAdd);
            map[index]=calculatedMaxProfit;
            return calculatedMaxProfit;
            
        }
        private int BinarySearch(List<Job> jobs, int currentJobIndex)
        {
            int lo = currentJobIndex;
            int high = jobs.Count - 1;
            int result = -1;

            while (lo <= high)
            {
                int mid = lo + (high - lo) / 2;

                if (jobs[currentJobIndex].EndTime <= jobs[mid].StartTime)
                {
                    result = mid;
                    high = mid - 1;
                }
                else
                {
                    lo = mid + 1;
                }
            }
            return result;
        }
        public class Job
        {
            public int StartTime;
            public int EndTime;
            public int Profit;

            public Job(int startTime, int endTime, int profit)
            {
                StartTime = startTime;
                EndTime = endTime;
                Profit = profit;
            }
        }
    }
}