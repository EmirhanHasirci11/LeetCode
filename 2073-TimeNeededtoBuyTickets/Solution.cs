namespace TimeNeededtoBuyTickets
{
    internal class Solution
    {       
        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            int queue = 0;
            while (tickets[k] != 0)
            {
                for(int i=0;i<tickets.Length;i++)
                {
                    if (tickets[i] == 0)
                        continue;
                    queue++;
                    tickets[i]--;
                    if (tickets[k] == 0)
                        break;
                }
            }
            return queue;


        }
    }

}