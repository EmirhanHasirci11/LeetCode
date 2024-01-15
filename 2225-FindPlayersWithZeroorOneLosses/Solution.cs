namespace FindPlayersWithZeroorOneLosses
{
    internal class Solution
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {

            HashSet<int> winners = new(matches.Select(x => x[0]));
            List<int> losers = new(matches.Select(x => x[1]));

            return new List<IList<int>>
        {
            winners.Except(losers).OrderBy(x => x).ToList(),
            losers.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).OrderBy(x => x).ToList()
        };


        }
    }
}