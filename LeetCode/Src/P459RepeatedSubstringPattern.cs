
namespace LeetCode.Src {
    /// <summary>
    ///  P459 Repeated Substring Pattern
    ///  href = https://leetcode.com/problems/repeated-substring-pattern/
    /// </summary>
    class P459RepeatedSubstringPattern {
        public static bool RepeatedSubstringPattern (string s) {
            return (s + s).Substring(1, s.Length * 2 - 2).Contains(s);
        }
    }
}
