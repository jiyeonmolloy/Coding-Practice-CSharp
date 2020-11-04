
namespace LeetCode.Src {
    /// <summary>
    /// P1446 Consecutive Characters
    ///  href = https://leetcode.com/problems/consecutive-characters/
    /// </summary>
    class P1446ConsecutiveCharacters {
        public static int MaxPower (string s) {
            if (s.Length == 1) {
                return 1;
            }

            int count = 1;
            int max = 1;
            char previous = s[0];

            for (int i = 1; i < s.Length; i++) {
                if (s[i].Equals(previous)) {
                    count++;
                    if (count > max) {
                        max = count;
                    }
                } else {
                    previous = s[i];
                    count = 1;
                }
            }

            return max;
        }
    }
}
