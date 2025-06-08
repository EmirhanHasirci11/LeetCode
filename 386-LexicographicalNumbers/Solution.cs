namespace LexicographicalNumbers
{
    public class Solution
    {
        public IList<int> LexicalOrder(int n)
        {
            List<int> result = new List<int>();

            // 1'den 9'a kadar olan sayılardan başla (0 ile başlamak anlamsız)
            for (int start = 1; start <= 9; ++start)
            {
                GenerateLexicalNumbers(start, n, result);
            }

            return result;
        }

        private void GenerateLexicalNumbers(int currentNumber, int limit, List<int> result)
        {
            // Eğer sayı sınırı aşarsa, dur
            if (currentNumber > limit) return;

            // Şu anki sayıyı listeye ekle
            result.Add(currentNumber);

            // Şu anki sayının sonuna 0–9 arası rakamlar eklemeyi dene
            for (int nextDigit = 0; nextDigit <= 9; ++nextDigit)
            {
                int nextNumber = currentNumber * 10 + nextDigit;

                // Eğer yeni sayı limit dahilindeyse, rekürsif olarak devam et
                if (nextNumber <= limit)
                {
                    GenerateLexicalNumbers(nextNumber, limit, result);
                }
                else
                {
                    break; // Limit aşıldıysa döngüden çık
                }
            }
        }
    }
}
