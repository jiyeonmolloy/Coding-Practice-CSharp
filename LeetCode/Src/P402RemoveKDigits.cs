using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    class P402RemoveKDigits {
        /// <summary>
        /// P402 Remove K Digits. href = https://leetcode.com/problems/remove-k-digits/
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string RemoveKdigits (string num, int k) {
            List<int> numArray = num.Select(s => (s - '0')).ToArray().ToList();
            int size = numArray.Count;

            if (size == k) {
                return "0";
            }

            int i = 0;
            while (k != 0 && i < (numArray.Count - 1)) {
                if (numArray[i] > numArray[i + 1]) {
                    numArray.RemoveAt(i);
                    k--;

                    if (i > 0) {
                        i--;
                    }
                } else {
                    i++;
                }
            }

            if (k > 0) {
                numArray.Reverse();
                numArray.RemoveRange(0, k);
            }

            if (numArray.All(x => x == 0)) {
                return "0";
            } else {
                return String.Join("", numArray.Select(x => x.ToString()).ToArray()).TrimStart(new Char[] { '0' });
            }
        }
    }
}
