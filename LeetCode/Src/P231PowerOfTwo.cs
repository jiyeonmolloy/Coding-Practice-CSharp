
namespace LeetCode.Src {
    class P231PowerOfTwo {
        /// <summary>
        /// P231 Power Of Two. href = https://leetcode.com/problems/power-of-two/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPowerOfTwo (int n) {
            if (n <= 0) {
                return false;
            }
            return (n & (n - 1)) == 0;
        }
    }
}
