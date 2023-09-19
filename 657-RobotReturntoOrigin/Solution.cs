namespace RobotReturntoOrigin
{
    internal class Solution
    {        
        public bool JudgeCircle(string moves)
        {
            int x=0;
            int y=0;
            foreach(char c in moves)
            {
                x += c == 'L' ? -1 : c == 'R' ? +1 : 0;
                y += c == 'D' ? -1 : c == 'U' ? +1 : 0;
            }
            return y==0 && x==0;
        }
    }
}