using System;

namespace LeetCode.Src {
    /// <summary>
    /// P171 Excel Sheet Column Number
    ///  href = https://leetcode.com/problems/excel-sheet-column-number/
    /// </summary>
    class P171ExcelSheetColumnNumber {
        public static int TitleToNumber (string s) {
            const int ALPHABET_MAX_COUNT = 26;
            s = s.ToLower();
            int size = s.Length;

            int column = s[size - 1] - 'a' + 1;
            int count = 1;
            for (int i = size - 2; i >= 0; i--) {
                column += (s[i] - 'a' + 1) * (int)Math.Pow(ALPHABET_MAX_COUNT, count);
                count++;
            }

            return column;
        }
    }
}
