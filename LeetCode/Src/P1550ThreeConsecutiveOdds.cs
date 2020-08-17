
namespace LeetCode.Src {
    /// <summary>
    /// P1550 Three Consecutive Odds
    ///  href = https://leetcode.com/problems/three-consecutive-odds/
    /// </summary>
    class P1550ThreeConsecutiveOdds {
        public static bool ThreeConsecutiveOdds (int[] arr) {
            int count = 0;
            bool start = false;
            foreach (int element in arr) {
                if ((count == 0 || (start && count > 0)) && (element % 2 == 1)) {
                    count++;
                    start = true;
                } else {
                    count = 0;
                    start = false;
                }

                if (count == 3) {
                    return true;
                }
            }

            return false;
        }
    }
}
