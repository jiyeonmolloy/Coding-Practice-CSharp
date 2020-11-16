using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1657 Determine If Two Strings Are Close
    ///  href = https://leetcode.com/problems/determine-if-two-strings-are-close/
    /// </summary>
    class P1657DetermineIfTwoStringsAreClose {
        public static bool CloseStrings (string word1, string word2) {
            if (word1.Length != word2.Length) {
                return false;
            }

            SortedDictionary<int, int> dictionaryWord1 = new SortedDictionary<int, int>();
            SortedDictionary<int, int> dictionaryWord2 = new SortedDictionary<int, int>();

            foreach (char character in word1) {
                int target = character - 'a';
                if (dictionaryWord1.ContainsKey(target)) {
                    dictionaryWord1[target]++;
                } else {
                    dictionaryWord1.Add(target, 1);
                }
            }

            foreach (char character in word2) {
                int target = character - 'a';
                if (!dictionaryWord1.ContainsKey(target)) {
                    return false;
                }
                if (dictionaryWord2.ContainsKey(target)) {
                    dictionaryWord2[target]++;
                } else {
                    dictionaryWord2.Add(target, 1);
                }
            }

            if (dictionaryWord1.Count != dictionaryWord2.Count) {
                return false;
            }

            int index = 0;
            while (index < dictionaryWord1.Count) {
                if (dictionaryWord1.ElementAt(index).Value == dictionaryWord2.ElementAt(index).Value) {
                    if (dictionaryWord1.ElementAt(index).Key == dictionaryWord2.ElementAt(index).Key) {
                        dictionaryWord1.Remove(dictionaryWord1.ElementAt(index).Key);
                        dictionaryWord2.Remove(dictionaryWord2.ElementAt(index).Key);
                        continue;
                    }
                }

                index++;
            }

            if (dictionaryWord1.Count == 0) {
                return true;
            }

            Dictionary<int, int> word1Pairs = dictionaryWord1.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            Dictionary<int, int> word2Pairs = dictionaryWord2.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value); ;

            for (int i = 0; i < dictionaryWord1.Count; i++) {
                if (word1Pairs.ElementAt(i).Value != word2Pairs.ElementAt(i).Value) {
                    return false;
                }
            }

            return true;
        }
    }
}
