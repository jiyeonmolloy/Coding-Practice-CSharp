
namespace LeetCode.Src {
    /// <summary>
    /// P1437 Check If All Ones Are At Least Length K Places Away
    /// href = https://leetcode.com/problems/check-if-all-1s-are-at-least-length-k-places-away/
    /// </summary>
    class P1437CheckIfAllOnesAreAtLeastLengthKPlacesAway {
        public static bool KLengthApart (int[] nums, int k) {
            int length = k;

            foreach (int num in nums) {
                if (num == 1) {
                    if (length < k) {
                        return false;
                    }

                    length = 0;

                } else {
                    length++;
                }
            }
            return true;
        }
    }
}
