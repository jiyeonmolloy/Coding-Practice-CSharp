using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P151 Reverse Words in a String
    ///  href = https://leetcode.com/problems/reverse-words-in-a-string/
    /// </summary>
    class P151ReverseWordsInAString {
        public static string ReverseWords (string s) {
            List<string> wordArray = s.Trim().Split(' ').Where(w => !string.IsNullOrEmpty(w)).ToList();
            string reversed = String.Empty;

            for (int i = wordArray.Count - 1; i >= 0; i--) {
                if (i != 0) {
                    reversed += wordArray[i] + " ";
                } else {
                    reversed += wordArray[i]; // last word
                }
            }

            return reversed;
        }
    }
}
