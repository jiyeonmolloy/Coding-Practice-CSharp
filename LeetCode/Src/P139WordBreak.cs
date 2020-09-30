using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P139 Word Break
    ///  href = https://leetcode.com/problems/word-break/
    /// </summary>
    class P139WordBreak {
        public static bool WordBreak (string s, IList<string> wordDict) { // bottom up dp
            bool[] cache = new bool[s.Length + 1];
            cache[0] = true;

            string word;
            for (int i = 1; i <= s.Length; i++) {
                for (int j = 0; j < i; j++) {
                    word = s.Substring(j, i - j);
                    if ((wordDict.Contains(word) && cache[j])) {
                        cache[i] = true;
                        break;
                    }
                }
            }

            return cache[s.Length];
        }
    }
}
