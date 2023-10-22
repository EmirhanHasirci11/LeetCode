namespace FirstBadVersion
{
    internal class Solution
    {
        /* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); in leetcode */
        public int FirstBadVersion(int n)
        {
            int left = 0;
            int right = n;
            while (left <= right) 
            {
                int middle = left+(right-left)/2;
                if (IsBadVersion(middle))
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return left;
        }
    }
}