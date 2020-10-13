using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P859 Buddy Strings
    ///  href = https://leetcode.com/problems/buddy-strings/
    /// </summary>
    class P859BuddyStrings {
        public static bool BuddyStrings (string A, string B) {
            if (A.Length != B.Length) {
                return false;
            }

            if (A.Equals(B)) {
                int[] frequency = new int[26];

                foreach (char character in A) {
                    frequency[character - 'a']++;
                }

                return frequency.Any(freq => freq > 1);
            }

            int first = -1;
            int second = -1;

            // Find two differences, if more than two characters are different it can't be a buddy string
            for (int i = 0; i < A.Length; i++) {
                if (A[i] == B[i]) continue;

                if (first == -1) {
                    first = i;
                } else if (second == -1) {
                    second = i;
                } else {
                    return false;
                }
            }

            return second != -1 && A[first].Equals(B[second]) && A[second].Equals(B[first]);
        }
    }
}
