using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1437 Check If All 1's Are at Least Length K Places Away. href = https://leetcode.com/problems/check-if-all-1s-are-at-least-length-k-places-away/
    /// </summary>
    class P1437CheckIfAll1sAreAtLeastKPlacesAway {
        public static bool KLengthApart (int[] nums, int k) {
            // Find position of 1 in nums array
            List<int> indexList = nums.Select((n, i) => new { i, n }).Where(t => t.n == 1).Select(t => t.i).ToList();

            int size = indexList.Count();
            int distance = 0;
            for (int i = size - 1; i > 0; --i) {
                distance = indexList[i] - indexList[i - 1] - 1;
                if (distance < k) {
                    return false;
                }
            }

            return true;
        }
    }
}
