using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1630 Arithmetic Subarrays
    ///  href = https://leetcode.com/problems/arithmetic-subarrays/
    ///  Improvements that can be made: Use HashSet over list and cache indexes
    /// </summary>
    class P1630ArithmeticSubarrays {
        public static IList<bool> CheckArithmeticSubarrays (int[] nums, int[] l, int[] r) {
            int m = l.Length;
            List<bool> answerList = new List<bool>(m);

            List<int> sortedSet = new List<int>();
            int left, right, count;
            int difference;
            bool answer = false;
            for (int i = 0; i < m; i++) {
                left = l[i];
                right = r[i];
                count = right - left + 1;

                if (count <= 2) {
                    answerList.Add(true);
                    continue;
                }

                sortedSet = nums.Skip(left).Take(count).OrderBy(key => key).ToList();

                answer = true;
                difference = sortedSet.ElementAt(1) - sortedSet.ElementAt(0);
                for (int j = 2; j < sortedSet.Count; j++) {
                    if (sortedSet.ElementAt(j) != (sortedSet.ElementAt(j - 1) + difference)) {
                        answer = false;
                        break;
                    }
                }

                answerList.Add(answer);
            }

            return answerList;
        }
    }
}
