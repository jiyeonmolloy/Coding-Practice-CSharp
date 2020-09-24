
namespace LeetCode.Src {
    /// <summary>
    /// P389 Find The Difference
    ///  href = https://leetcode.com/problems/find-the-difference/
    /// </summary>
    class P389FindTheDifference {
        public static char FindTheDifference (string s, string t) {
            int difference = 0;

            foreach (char letter in s) {
                difference ^= letter;
            }

            foreach (char letter in t) {
                difference ^= letter;
            }

            return (char)difference;
        }
    }
}
