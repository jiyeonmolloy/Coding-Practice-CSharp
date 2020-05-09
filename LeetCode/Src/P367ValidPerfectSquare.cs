
namespace LeetCode.Src {
    /// <summary>
    /// P367 Valid Perfect Square. href = https://leetcode.com/problems/valid-perfect-square/
    /// </summary>
    class P367ValidPerfectSquare {
        public static bool IsPerfectSquare (int num) {
            for (long i = 1; i * i <= num; i++) {
                if (i * i == num) {
                    return true;
                }
            }
            return false;
        }
    }
}
