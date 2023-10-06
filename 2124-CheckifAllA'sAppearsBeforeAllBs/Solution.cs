namespace CheckifAllA_sAppearsBeforeAllBs
{
    internal class Solution
    {        
        public bool CheckString(string s)
        {
            bool flag = false;
            foreach(char c in s)
            {
                if (c == 'b')
                    flag=true;
                if (flag && c == 'a')
                    return false;
            }
            return true;
        }
    }
}