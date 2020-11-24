using System;
using System.Text;

namespace LeetCode.Src {
    /// <summary>
    ///  P1663 Smallest String With A Given Numeric Value
    ///  href = https://leetcode.com/contest/weekly-contest-216/problems/smallest-string-with-a-given-numeric-value/
    /// </summary>
    class P1663SmallestStringWithAGivenNumericValue {
        public static string GetSmallestString (int n, int k) {
            StringBuilder sb = new StringBuilder(n);

            int i = n - 1;
            int cost;
            while (i >= 0) {
                cost = k - i;
                if (cost >= 26) {
                    int divisor = cost / 26;
                    string end = new String('z', divisor);
                    sb.Insert(0, end);
                    k -= 26 * divisor;
                    i -= divisor;
                } else if (cost == 1) {
                    string init = new String('a', i + 1);
                    sb.Insert(0, init);
                    break;
                } else if (cost > 0) {
                    sb.Insert(0, (char)(cost + 'a' - 1));
                    k -= cost;
                    i--;
                }
            }

            return sb.ToString();
        }
    }
}
