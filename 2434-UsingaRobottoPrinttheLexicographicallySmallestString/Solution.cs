using System.Text;

namespace UsingaRobottoPrinttheLexicographicallySmallestString
{
    internal class Solution
    {
        public string RobotWithString(string s)
        {
            Stack<char> stack = new Stack<char>();
            int[] freq = new int[26];

            // Karakterlerin frekanslarını say
            foreach (char ch in s)
            {
                freq[ch - 'a']++;
            }

            StringBuilder t = new StringBuilder();

            foreach (char ch in s)
            {
                stack.Push(ch);
                freq[ch - 'a']--;

                // Stack'in tepesindeki karakteri çıkarabilir miyiz kontrol et
                while (stack.Count > 0 && stack.Peek() <= SmallestChar(freq))
                {
                    t.Append(stack.Pop());
                }
            }

            // Stack'te kalan karakterleri ekle
            while (stack.Count > 0)
            {
                t.Append(stack.Pop());
            }

            return t.ToString();
        }
        private char SmallestChar(int[] freq)
        {
            for (int i = 0; i < 26; i++)
            {
                if (freq[i] > 0)
                {
                    return (char)('a' + i);
                }
            }
            return 'a';
        }
    }
}
