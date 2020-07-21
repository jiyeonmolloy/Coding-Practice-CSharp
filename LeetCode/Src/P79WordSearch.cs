using System;

namespace LeetCode.Src {
    /// <summary>
    /// P79 Word Search
    ///  href = https://leetcode.com/problems/word-search/
    /// </summary>
    class P79WordSearch {
        public static bool Exist (char[][] board, string word) {
            if (String.IsNullOrEmpty(word)) {
                return true;
            }

            if (board == null || board[0].Length == 0) {
                return false;
            }

            int rowCount = board.Length;
            int colCount = board[0].Length;

            for (int i = 0; i < rowCount; i++) {
                for (int j = 0; j < colCount; j++) {
                    if (SearchWord(board, word, i, j, 0)) {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool SearchWord (char[][] board, string word, int row, int col, int index) {
            if (index == word.Length) {
                return true;
            }

            if (row < 0 || col < 0 || row >= board.Length || col >= board[0].Length) {
                return false;
            }

            if (word[index] != board[row][col]) {
                return false;
            }

            board[row][col] = '#';
            int targetIndex = index + 1;

            bool wordExists =
                SearchWord(board, word, row + 1, col, targetIndex) ||
                SearchWord(board, word, row - 1, col, targetIndex) ||
                SearchWord(board, word, row, col + 1, targetIndex) ||
                SearchWord(board, word, row, col - 1, targetIndex);

            board[row][col] = word[index];

            return wordExists;
        }
    }
}
