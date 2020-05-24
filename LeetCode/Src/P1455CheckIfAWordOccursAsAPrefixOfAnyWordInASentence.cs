using System;

namespace LeetCode.Src {
    class P1455CheckIfAWordOccursAsAPrefixOfAnyWordInASentence {
        /// <summary>
        /// P1455 Check If a Word Occurs As a Prefix of Any Word in a Sentence. href = https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/
        /// </summary>
        /// <param name="sentence"></param>
        /// <param name="searchWord"></param>
        /// <returns></returns>
        public static int IsPrefixOfWord (String sentence, String searchWord) {
            string[] wordArray = sentence.Split(' ');

            for (int i = 0; i < wordArray.Length; i++) {
                if (wordArray[i].StartsWith(searchWord)) {
                    return i + 1;
                }
            }

            return -1;
        }
    }
}
