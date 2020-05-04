using System;

namespace LeetCode.Src {
    class P476NumberComplement {
        /// <summary>
        /// P476 Number Complement. href = https://leetcode.com/problems/number-complement/
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int FindComplement (int num) {
            if (num == 0) {
                return Int32.MaxValue;
            }

            char[] binaries = Convert.ToString((int)num, 2).ToCharArray();

            for (int i = 0; i < binaries.Length; i++) {
                if (binaries[i] == '0') {
                    binaries[i] = '1';
                } else {
                    binaries[i] = '0';
                }
            }

            return Convert.ToInt32(new string(binaries), 2);
        }
    }
}
