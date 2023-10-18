namespace LemonadeChange
{
    internal class Solution
    {
        public bool LemonadeChange(int[] bills)
        {
            Stack<int> bills10 = new();
            Stack<int> bills5 = new();
            foreach(int bill in bills)
            {
                if(bill==5)
                    bills5.Push(bill);
                else if (bill == 10)
                {
                    bills10.Push(bill);
                    if (bills5.Count <= 0)
                        return false;
                    else
                        bills5.Pop();
                }
                else if (bill == 20)
                {
                    if (bills10.Count > 0)
                    {
                        bills10.Pop();
                        if (bills5.Count <= 0)
                            return false;
                        bills5.Pop();
                    }
                    else if (bills5.Count > 0)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (bills5.Count > 0)
                            {
                                return false;
                            }
                            bills5.Pop();
                        }
                    }
                    else
                        return false;
                }
            }
            return true;

        }
    }
}