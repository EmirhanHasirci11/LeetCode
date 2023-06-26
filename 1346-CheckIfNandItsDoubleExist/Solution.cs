namespace CheckIfNandItsDoubleExist
{
    internal class Solution
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> hash = new();
            foreach (int number in arr)
            {
                if (hash.Contains(number * 2) || (number % 2 == 0 && hash.Contains(number / 2)))
                    return true;
                hash.Add(number);
            }
            return false;
        }
    }
}