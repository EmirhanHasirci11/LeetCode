using System.Collections.Generic;

namespace TheEmployeeThatWorkedontheLongestTask
{
    internal class Solution
    {
        public int HardestWorker(int n, int[][] logs)
        {
            int maxUnitTime = 0,workerId = 0,latestWorkTime = 0;
            for (int i = 0; i < logs.Length; i++)
            {
                if ((logs[i][1]-latestWorkTime)>maxUnitTime|| ((logs[i][1] - latestWorkTime) == maxUnitTime && workerId > logs[i][0]))
                {
                    maxUnitTime = logs[i][1]-latestWorkTime;
                    workerId = logs[i][0];
                }
                latestWorkTime = logs[i][1];
            }
            return workerId;
        }
    }
}