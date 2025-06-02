namespace Candy
{
    internal class Solution
    {
         
        public int Candy(int[] ratings)
        {
            int[] candies = new int[ratings.Length];
            Array.Fill(candies, 1);
            for(int i = 1; i < candies.Length; i++) 
                if(ratings[i] > ratings[i-1])
                    candies[i]=candies[i-1]+1;

            for(int i = candies.Length-2;i>=0;i--)
                if (ratings[i]>ratings[i+1])
                    candies[i]=Math.Max(candies[i],candies[i+1]+1);

            int totalCandyCount = 0;
            foreach (int i in candies)
                totalCandyCount += i;
            return totalCandyCount;
            
        }
    }
}
