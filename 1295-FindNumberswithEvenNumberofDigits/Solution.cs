namespace FindNumberswithEvenNumberofDigits
{
    internal class Solution
    {        
        public int FindNumbers(int[] nums)
        {
            int countOfEven = 0;
            foreach(int num in nums)
            {
                int temp=num;
                int countTemp = 0;
                while(temp != 0)
                {
                    temp /= 10;
                    countTemp++;
                }
                if (countTemp % 2 == 0)
                    countOfEven++;
            }
            return countOfEven;
        }
    }
}