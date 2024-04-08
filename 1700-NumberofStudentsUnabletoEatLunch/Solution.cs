namespace NumberofStudentsUnabletoEatLunch
{
    internal class Solution
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            int[] res = new int[] { 0, 0 };
            int k;
            foreach (int i in students)            
                res[i]++;

            for (k=0; k < students.Length && res[sandwiches[k]] > 0; k++)
                res[sandwiches[k]]--;

            return students.Length - k;


        }
    }
}
