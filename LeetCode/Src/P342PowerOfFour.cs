
namespace LeetCode.Src {
    /// <summary>
    /// P342 Power of Four
    ///  href = https://leetcode.com/problems/power-of-four/
    /// </summary>
    class P342PowerOfFour {
        public static bool IsPowerOfFour (int num) {
            if (num <= 0) {
                return false;
            }

            while (num % 4 == 0 && num > 0) {
                num /= 4;
            }

            return num == 1;
        }
    }
}
