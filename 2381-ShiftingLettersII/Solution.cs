using System.Text;

namespace ShiftingLettersII
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  ShiftingLetters("abc",new int[][] { [0, 1, 0], [1, 2, 1], [0, 2, 1] }));
        }
        public static string ShiftingLetters(string s, int[][] shifts)
        {
            int n = s.Length;
            int[] shift = new int[n + 1];

            foreach (var shiftOp in shifts)
            {
                int start = shiftOp[0], end = shiftOp[1], direction = shiftOp[2];
                shift[start] += (direction == 1 ? 1 : -1);
                if (end + 1 < n) shift[end + 1] -= (direction == 1 ? 1 : -1);
            }

            int currentShift = 0;
            StringBuilder result = new StringBuilder(s);
            for (int i = 0; i < n; ++i)
            {
                currentShift += shift[i];
                shift[i] = currentShift;
            }

            for (int i = 0; i < n; ++i)
            {
                int netShift = (shift[i] % 26 + 26) % 26;
                result[i] = (char)('a' + (s[i] - 'a' + netShift) % 26);
            }

            return result.ToString();
        }
    }
}
