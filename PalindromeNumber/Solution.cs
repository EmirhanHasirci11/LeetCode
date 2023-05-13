namespace PalindromeNumber
{
    internal class Solution
    {        
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            string pal = x.ToString();
            int left = 0;
            int right = x.ToString().Length-1;
            while (left < right)
            {
                if (pal[left++] != pal[right--])
                {
                    return false;
                }

            }
            return true;
        }
        //////Solution2//////
        //////With built in methods/////
        public bool IsPalindrome2(int x)
        {
            Char[] y =x.ToString().ToCharArray();
            Array.Reverse(y);
            return x.ToString() == new string(y);
        }
    }
}