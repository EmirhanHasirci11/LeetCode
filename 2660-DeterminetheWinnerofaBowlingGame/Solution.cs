namespace DeterminetheWinnerofaBowlingGame
{
    internal class Solution
    {        
        public int IsWinner(int[] player1, int[] player2)
        {
            int sumOfPlayer1 = CalculatePlayerPoint(player1, 1);
            int sumOfPlayer2=CalculatePlayerPoint(player2, 1);
            return sumOfPlayer1>sumOfPlayer2?1:sumOfPlayer1==sumOfPlayer2?0:2;
        }
        private static int CalculatePlayerPoint(int[] playerPoints, int multiplier)
        {
            int sumOfPoints = 0;
            int multiplierTime = 2;
            for (int i = 0; i < playerPoints.Length; i++)
            {
                sumOfPoints += playerPoints[i] * multiplier;
                if (multiplier == 2)
                    multiplierTime--;
                if(multiplierTime==0)
                    multiplier = 1;
                if (playerPoints[i] == 10)
                {
                    multiplier = 2;
                    multiplierTime=2;
                }
            }
            return sumOfPoints;
        }
    }
}