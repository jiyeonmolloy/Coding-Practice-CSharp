
namespace LeetCode {
    /// <summary>
    /// P1784 Check If Binary String Has At Most One Segment Of Ones
    /// href = https://leetcode.com/problems/check-if-binary-string-has-at-most-one-segment-of-ones/
    /// </summary>
    class P1784CheckIfBinaryStringHasAtMostOneSegmentOfOnes {
        public static bool CheckOnesSegment (string s) {
            return !s.Contains("01");
        }
    }
}
