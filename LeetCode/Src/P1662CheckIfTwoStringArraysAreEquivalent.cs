
namespace LeetCode.Src {
    /// <summary>
    ///  P1662 Check If Two String Arrays Are Equivalent
    ///  href = https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
    /// </summary>
    class P1662CheckIfTwoStringArraysAreEquivalent {
        public static bool ArrayStringsAreEqual (string[] word1, string[] word2) {
            string word1C = string.Join("", word1);
            string word2C = string.Join("", word2);

            return word1C.Equals(word2C);
        }
    }
}
