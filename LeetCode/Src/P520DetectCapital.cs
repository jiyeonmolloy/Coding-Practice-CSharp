using System;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P520 Detect Capital
    ///  href = https://leetcode.com/problems/detect-capital/
    /// </summary>
    class P520DetectCapital {
        public static bool DetectCapitalUse (string word) {
            if (Char.IsUpper(word[0])) {
                word = word.Substring(1);
            }
            return word.All(Char.IsUpper) || word.All(Char.IsLower);
        }
    }
}
