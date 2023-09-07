namespace FindtheStudentthatWillReplacetheChalk
{
    internal class Solution
    {        
        public int ChalkReplacer(int[] chalk, int k)
        {
            long sumOfChalk = 0;
            for(int i = 0; i < chalk.Length; i++)
            {
                sumOfChalk += chalk[i];
            }
            long modularOfChalk = k%sumOfChalk;

            for(int i=0;i<chalk.Length; i++)
            {
                if (chalk[i]>modularOfChalk)
                    return i;
                modularOfChalk-= chalk[i];
            }
            return 0;
        }
    }
}