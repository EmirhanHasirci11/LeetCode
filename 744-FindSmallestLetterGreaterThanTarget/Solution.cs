namespace FindSmallestLetterGreaterThanTarget
{
    internal class Solution
    {       
        public char NextGreatestLetter(char[] letters, char target)
        {
            char greaterThanTarget = letters[0];
            bool firstGreaterSelected = false;
            foreach (char c in letters)
            {
                if (c > target)
                {
                    if (firstGreaterSelected == false)
                    {
                        greaterThanTarget = c;
                        firstGreaterSelected= true;
                    }
                    if (c < greaterThanTarget)
                        greaterThanTarget = c;
                }

            }
            return greaterThanTarget;
        }
    }
}