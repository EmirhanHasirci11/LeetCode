namespace FurthestPointFromOrigin
{
    internal class Solution
    {
        public int FurthestDistanceFromOrigin(string moves)
        {
            int countOfDistance = 0;
            int emptySlot = 0;
            foreach (char move in moves)
            {
                if (move == '_')
                    emptySlot++;
                else
                    countOfDistance += move == 'R' ? 1 : move == 'L' ? -1 : 0;
            }
            return Math.Abs(countOfDistance) + emptySlot;
            

        }
    }
}
