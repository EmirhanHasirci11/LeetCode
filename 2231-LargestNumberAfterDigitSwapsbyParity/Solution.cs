namespace LargestNumberAfterDigitSwapsbyParity
{
    internal class Solution
    {        
        public int LargestInteger(int num)
        {
            PriorityQueue<int,int>odd= new();
            PriorityQueue<int,int>even= new();

            int numCopy = num;

            while(numCopy > 0)
            {
                if ((numCopy % 10) % 2 == 0)
                    even.Enqueue(numCopy % 10, numCopy % 10);
                else
                    odd.Enqueue(numCopy % 10, numCopy % 10);
                num/=10;
            }

            int result = 0, multiple = 1;

            while (num > 0)
            {
                if ((num % 10) % 2 == 0)
                    result += multiple*even.Dequeue();
                else
                    result+= multiple*odd.Dequeue();
                multiple *= 10;
                num /= 10;
            }
            return result;
        }
    }
}