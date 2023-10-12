namespace NumberofSeniorCitizens
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            CountSeniors(new string[] { "7868190130M7522", "5303914400F9211", "9273338290F4010" });
        }
        public static int CountSeniors(string[] details)
        {
            int countOfSeniorCitizen = 0;
            foreach (string str in details)
                if (Convert.ToInt32(str.Substring(11, 2)) > 60)
                    countOfSeniorCitizen++;
            return countOfSeniorCitizen;
        }
    }
}