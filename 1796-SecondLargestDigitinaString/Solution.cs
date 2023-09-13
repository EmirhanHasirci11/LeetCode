namespace SecondLargestDigitinaString
{
    internal class Solution
    {        
        public static int SecondHighest(string s)
        {
            int largest = -1, secondLargest = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    int digit = s[i] - '0';
                    if (digit > largest)
                    {
                        secondLargest = largest;
                        largest = digit;
                    }
                    else if (digit == largest)
                        continue;
                    else if (digit > secondLargest)
                        secondLargest = digit;

                }
            }
            return secondLargest;
        }
    }
}