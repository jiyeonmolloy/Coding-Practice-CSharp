using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    ///  P1624 Largest Substring Between Two Equal Characters
    ///  href = https://leetcode.com/problems/largest-substring-between-two-equal-characters/
    /// </summary>
    class P1624LargestSubstringBetweenTwoEqualCharacters {
        public static int MaxLengthBetweenEqualCharacters (string s) {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            char target;

            int max = -1;
            int distance = 0;
            for (int i = 0; i < s.Length; i++) {
                target = s[i];
                if (dict.ContainsKey(target)) {
                    distance = i - dict[target] - 1;
                    if (distance > max) {
                        max = distance;
                    }
                } else {
                    dict.Add(target, i); // start index
                }
            }

            return max;
        }
    }
}
