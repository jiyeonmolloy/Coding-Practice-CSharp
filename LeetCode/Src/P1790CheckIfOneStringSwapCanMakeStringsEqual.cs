
namespace LeetCode.Src {
    /// <summary>
    /// P1790 Check If One String Swap Can Make Strings Equal
    /// href = https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/
    /// </summary>
    class P1790CheckIfOneStringSwapCanMakeStringsEqual {
        public static bool AreAlmostEqual (string s1, string s2) {
            bool isDifferent = false;
            char toSwapS1 = 'a';
            char toSwapS2 = 'a';

            for (int i = 0; i < s1.Length; i++) {
                char targetS1 = s1[i];
                char targetS2 = s2[i];
                if (targetS1.Equals(targetS2)) {
                    continue;
                }

                if (!isDifferent) {
                    toSwapS1 = targetS1;
                    toSwapS2 = targetS2;
                    isDifferent = true;
                    continue;
                }

                if (targetS1.Equals(toSwapS2) && targetS2.Equals(toSwapS1)) {
                    isDifferent = false;
                    continue;
                }

                return false;
            }

            return !isDifferent;
        }
    }
}
