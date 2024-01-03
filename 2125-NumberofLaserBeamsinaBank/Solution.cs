namespace NumberofLaserBeamsinaBank
{
    internal class Solution
    {        
        public int NumberOfBeams(string[] bank)
        {
            int lastLaserRow = 0;
            int countOfLaserBeam = 0;
            foreach(string bankName in bank)
            {
                int curRowCount = countOfBeams(bankName);
                if (curRowCount == 0)
                    continue;

                countOfLaserBeam += curRowCount * lastLaserRow;
                lastLaserRow = curRowCount;
            }
            return countOfLaserBeam;
                
        }
        public int countOfBeams(string row)
        {
            int countOfCurrentRowBeam = 0;
            foreach(char c in row)
            {
                countOfCurrentRowBeam += c - '0';
            }
            return countOfCurrentRowBeam;
        }
    }
}