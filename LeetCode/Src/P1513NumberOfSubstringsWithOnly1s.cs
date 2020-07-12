using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1513 Number of Substrings with only 1s
    ///  href = https://leetcode.com/problems/number-of-substrings-with-only-1s/
    ///  key : Partial Sum
    /// </summary>
    class P1513NumberOfSubstringsWithOnly1s {
        public static int NumSub (string s) {
            const char delimiter = '0';
            const int mod = (int)(1e9) + 7;
            string[] subStrings = s.Split(delimiter);
            long indexes = subStrings.Sum(subString => PartialSum(subString.Length) % mod);
            return (int)indexes;
        }

        private static long PartialSum (long num) { 
            return num * (num + 1) / 2;
        }
    }
}
