using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1529 Bulb Switcher IV
    ///  href = https://leetcode.com/problems/bulb-switcher-iv/
    /// </summary>
    class P1529BulbSwitcherIV {
        public static int MinFlips (string target) {
            char expected = '1';
            int flipCount = 0;

            foreach (char flipSwitch in target.Where(flipSwitch => flipSwitch.Equals(expected))) {
                flipCount++;
                expected = expected.Equals('1') ? '0' : '1';
            }

            return flipCount;
        }
    }
}
