using System.Collections.Generic;

namespace LeetCode.Src {
    class P438FindAllAnagramsInAString {
        /// <summary>
        /// P438 Find All Anagrams In A String. href = "https://leetcode.com/problems/find-all-anagrams-in-a-string/"
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static IList<int> FindAnagrams (string s, string p) {
            IList<int> anagramIndexList = new List<int>();
            const int ALPHABET_MAX_COUNT = 26;
            int sLen = s.Length;
            int pLen = p.Length;

            if (pLen > sLen) {
                return anagramIndexList;
            }

            int[] pAlphabetCount = new int[ALPHABET_MAX_COUNT];
            int[] sAlphabetCount = new int[ALPHABET_MAX_COUNT];
            bool isAnagram;
            int anagramIndex;
            foreach (char c in p) {
                pAlphabetCount[c - 'a']++;
            }

            for (int i = 0; i < sLen; i++) {
                sAlphabetCount[s[i] - 'a']++;

                if (i >= pLen - 1) {
                    isAnagram = true;
                    for (int j = 0; j < ALPHABET_MAX_COUNT; j++) {
                        if (sAlphabetCount[j] != pAlphabetCount[j]) {
                            isAnagram = false;
                            break;
                        }
                    }

                    anagramIndex = i - pLen + 1;

                    if (isAnagram) {
                        anagramIndexList.Add(anagramIndex);
                    }

                    sAlphabetCount[s[anagramIndex] - 'a']--;
                }
            }

            return anagramIndexList;
        }
    }
}
