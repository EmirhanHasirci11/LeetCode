namespace NumberofStudentsDoingHomeworkataGivenTime
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int countOfValidStudent = 0;
            for(int i=0;i<startTime.Length;i++)
            {
                if (queryTime >= startTime[i] && queryTime <= endTime[i])
                    countOfValidStudent++;
            }
            return countOfValidStudent;
        }
    }
}