using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P290 Word Pattern
    ///  href = https://leetcode.com/problems/word-pattern/
    /// </summary>
    class P290WordPattern {
        public static bool WordPattern (string pattern, string str) {
            Dictionary<char, string> dictionary = new Dictionary<char, string>();
            string[] wordList = str.Split(' ');

            if (pattern.Length != wordList.Length) {
                return false;
            }

            char targetPattern;
            string targetWord;
            for (int i = 0; i < wordList.Length; i++) {
                targetPattern = pattern[i];
                targetWord = wordList[i];
                if (dictionary.ContainsKey(targetPattern)) {
                    if (!dictionary[targetPattern].Equals(targetWord)) {
                        return false;
                    }
                } else if (dictionary.ContainsValue(targetWord)) {
                    return false;
                } else {
                    dictionary.Add(targetPattern, wordList[i]);
                }
            }
            return true;
        }
    }
}
