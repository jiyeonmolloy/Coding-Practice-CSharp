using System;

namespace LeetCode.Src {
    /// <summary>
    /// P824 Goat Latin
    ///  href = https://leetcode.com/problems/goat-latin/
    /// </summary>
    class P824GoatLatin {
        public static string ToGoatLatin (string S) {
            string[] words = S.Split(' ');

            string word;
            char first;
            for (int i = 0; i < words.Length; i++) {
                word = words[i].ToLower();
                if (!word.StartsWith("a") && !word.StartsWith("e") && !word.StartsWith("i") && !word.StartsWith("o") && !word.StartsWith("u")) {
                    first = words[i][0];
                    words[i] = words[i].Remove(0, 1);
                    words[i] += first;
                }
                words[i] += "ma" + AddAs(i + 1);
            }

            return string.Join(" ", words);
        }

        private static string AddAs (int number) {
            string a = String.Empty;
            for (int i = 0; i < number; i++) {
                a += "a";
            }

            return a;
        }
    }
}
