using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    ///  P1673 Find The Most Competitive Subsequence
    /// href = https://leetcode.com/problems/find-the-most-competitive-subsequence/
    /// </summary>
    class P1673FindTheMostCompetitiveSubsequence {
        public static int[] MostCompetitive (int[] nums, int k) {
            // Key: Monotonic Stack
            int n = nums.Length;
            if (n == k) {
                return nums;
            }

            Stack<int> monoStack = new Stack<int>();

            int remainder;
            int target;
            for (int i = 0; i < n; i++) {
                remainder = n - i;
                target = nums[i];

                while (monoStack.Count > 0 && monoStack.Peek() > target && (remainder + monoStack.Count) > k) {
                    monoStack.Pop();
                }

                monoStack.Push(target);
            }

            return monoStack.Reverse().Take(k).ToArray();
        }
    }
}
