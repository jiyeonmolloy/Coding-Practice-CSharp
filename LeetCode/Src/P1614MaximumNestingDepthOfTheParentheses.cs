using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1614 Maximum Nesting Depth Of The Parentheses
    ///  href = https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/
    /// </summary>
    class P1614MaximumNestingDepthOfTheParentheses {
        public static int MaxDepth (string s) {
            int max = 0;
            int current = 0;
            for (int i = 0; i < s.Length; i++) {
                if (s[i].Equals('(')) {
                    current++;
                } else if (s[i].Equals(')')) {
                    current--;
                }

                max = Math.Max(current, max);
            }

            return max;
        }
    }
}
