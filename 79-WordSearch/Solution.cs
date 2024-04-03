namespace WordSearch
{
    internal class Solution
    {       
        public bool Exist(char[][] board, string word)
        {
            int m = board.Length;
            int n = board[0].Length;

            Func<int, int, int, bool> backtrack = null;
            backtrack = (i, j, k) => {
                if (k == word.Length)
                {
                    return true;
                }
                if (i < 0 || i >= m || j < 0 || j >= n || board[i][j] != word[k])
                {
                    return false;
                }

                char temp = board[i][j];
                board[i][j] = '\0';
                bool result = backtrack(i + 1, j, k + 1) ||
                              backtrack(i - 1, j, k + 1) ||
                              backtrack(i, j + 1, k + 1) ||
                              backtrack(i, j - 1, k + 1);

                board[i][j] = temp;
                return result;
            };

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (backtrack(i, j, 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
