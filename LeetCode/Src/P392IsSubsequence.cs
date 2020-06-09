
namespace LeetCode.Src {
    /// <summary>
    /// P392 Is Subsequence
    ///  href = https://leetcode.com/problems/is-subsequence/
    /// </summary>
    class P392IsSubsequence {
        public static bool IsSubsequence (string s, string t) {
            int sLength = s.Length;
            int tLength = t.Length;

            if (sLength > tLength) {
                return false;
            }

            if (sLength == 0) {
                return true;
            }

            int sIndex = 0;
            for (int i = 0; i < tLength; i++) {
                if (s[sIndex] == t[i]) {
                    sIndex++;
                    if (sIndex == sLength) {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
