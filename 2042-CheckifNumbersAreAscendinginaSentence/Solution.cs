namespace CheckifNumbersAreAscendinginaSentence
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public bool AreNumbersAscending(string s)
        {
            string[] arr = s.Split();
            int prev = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                int num = 0;
                if (int.TryParse(arr[i], out num))
                {
                    if (num <= prev)
                        return false;

                    prev = num;
                }
            }

            return true;

        }
    }
}