namespace RelativeRanks
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            FindRelativeRanks(new int[] { 5, 4, 3, 2, 1 });
        }
        public static string[] FindRelativeRanks(int[] score)
        {
            int lengtOfScore = score.Length;
            string[] result = new string[lengtOfScore];
            int[] sortedArray = new int[lengtOfScore];
            Array.Copy(score, sortedArray, lengtOfScore);
            Array.Sort(sortedArray);
            Array.Reverse(sortedArray);
            for (int i = 0; i < lengtOfScore; i++)
            {
                string resultText = string.Empty;
                switch (i)
                {
                    case 0:
                        resultText = "Gold Medal";
                        break;
                    case 1:
                        resultText = "Silver Medal";
                        break;
                    case 2:
                        resultText = "Bronze Medal";
                        break;
                    default:
                        resultText = (i+1).ToString();
                        break;
                }
                result[Array.IndexOf(score,sortedArray[i])] = resultText;
            }
            return result;
        }
    }
}