namespace NumberofEmployeesWhoMettheTarget
{
    internal class Solution
    {
        public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            return hours.ToList().Where(x => x >= target).Count();
        }
    }
}