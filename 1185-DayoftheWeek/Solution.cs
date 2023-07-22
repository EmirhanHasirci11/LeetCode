namespace DayoftheWeek
{
    internal class Solution
    {        
        public string DayOfTheWeek(int day, int month, int year)
        {
            DateOnly date = new DateOnly(year,month,day);
            return date.DayOfWeek.ToString();
        }
    }
}