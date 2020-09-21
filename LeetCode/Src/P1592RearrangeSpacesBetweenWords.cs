using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1592 Rearrange Spaces Between Words
    ///  href = https://leetcode.com/problems/rearrange-spaces-between-words/
    /// </summary>
    class P1592RearrangeSpacesBetweenWords {
        public static string ReorderSpaces (string text) {
            if (text.Length == 1) {
                return text;
            }

            List<string> words = text.Split(' ').Where(x => !String.IsNullOrEmpty(x)).ToList();
            IEnumerable<char> spaces = text.Where(x => x.Equals(' '));
            int spaceCount = spaces.Count();
            string output = String.Empty;

            if (words.Count == 1) {
                output = words[0];
                for (int i = 0; i < spaceCount; i++) {
                    output += ' ';
                }

                return output;
            }

            int spacing = spaceCount / (words.Count - 1);
            int remainderSpace = spaceCount % (words.Count - 1);
            for (int i = 0; i < words.Count; i++) {
                string word = words[i];
                output += word;
                if (i == words.Count - 1) {
                    for (int j = 0; j < remainderSpace; j++) {
                        output += ' ';
                    }
                } else {
                    for (int j = 0; j < spacing; j++) {
                        output += ' ';
                    }
                }

            }

            return output;
        }
    }
}
