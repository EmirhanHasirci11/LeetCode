namespace K_thSmallestinLexicographicalOrder
{
    public class Solution
    {
        public int FindKthNumber(int n, int k)
        {
            int current = 1;
            k--; // İlk sayı zaten 1, onu sayıyoruz

            while (k > 0)
            {
                long count = CountPrefix(current, n);
                if (count <= k)
                {
                    // Bu prefix'te yeterli sayı yoksa sağ kardeşe geç
                    current++;
                    k -= (int)count;
                }
                else
                {
                    // Bu prefix altında kal, bir kat derine in
                    current *= 10;
                    k--;
                }
            }

            return current;
        }

        // Belirli bir prefix altında kaç sayı var (n'e kadar)
        private long CountPrefix(long prefix, long n)
        {
            long count = 0;
            long curr = prefix, next = prefix + 1;

            while (curr <= n)
            {
                count += Math.Min(n + 1, next) - curr;
                curr *= 10;
                next *= 10;
            }

            return count;
        }
    }
}
