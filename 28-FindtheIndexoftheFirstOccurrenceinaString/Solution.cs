namespace FindtheIndexoftheFirstOccurrenceinaString
{
    internal class Solution
    {              
        public int StrStr(string haystack, string needle)
        {
            if (needle == null) return -1;
            int[] lps =new int [needle.Length];
            int prevLPS = 0,j=0 ,i = 1;
            while (i < needle.Length)
            {
                if (needle[i] == needle[prevLPS])
                {
                    lps[i] = prevLPS + 1;
                    prevLPS++;
                    i++;
                }
                else if (prevLPS == 0)
                {
                    lps[i] = 0;
                    i++;
                }
                else
                    prevLPS = lps[prevLPS - 1];
            }
            i= 0;
            while (i < haystack.Length)
            {
                if (haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    if (j == 0)
                        i++;
                    else
                        j = lps[j-1];
                }
                if (j == needle.Length)
                    return i - needle.Length;
            }

            return -1;
        }
    }
}