namespace KthLargestElementinaStream
{
    public class KthLargest
    {
        List<int> ListOfSortedNums;
        int numOfLatest;

        public KthLargest(int k, int[] nums)
        {
            numOfLatest = k;
            ListOfSortedNums = new(nums);
            ListOfSortedNums.Sort();
        }

        public int Add(int val)
        {
            
            ListOfSortedNums.Add(val);
            ListOfSortedNums.Sort();
            return ListOfSortedNums[ListOfSortedNums.Count - numOfLatest];
        }
    }
}
