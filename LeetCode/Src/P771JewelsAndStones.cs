using System;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P771 Jewels And Stones. href = https://leetcode.com/problems/jewels-and-stones/
    /// </summary>
    class P771JewelsAndStones {
        public static int NumJewelsInStones (string J, string S) {
            int jewels = 0;

            foreach (char jewel in J) {
                jewels += S.Count(x => x == jewel);
            }

            return jewels;
        }
    }
}
