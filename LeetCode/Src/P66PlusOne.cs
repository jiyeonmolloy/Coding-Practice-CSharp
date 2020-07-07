using System;

namespace LeetCode.Src {
    /// <summary>
    /// P66 Plus One
    ///  href = https://leetcode.com/problems/plus-one/
    /// </summary>
    class P66PlusOne {
        public static int[] PlusOne (int[] digits) {
            int size = digits.Length;

            // Iterate from the back
            int carry = 1;
            int newDigit;
            for (int i = size - 1; i >= 0; i--) {
                newDigit = digits[i] + carry;
                digits[i] = newDigit % 10;
                carry = newDigit == 10 ? 1 : 0;
                if (carry == 0) {
                    return digits;
                }
            }

            int[] result = new int[size + 1];
            result[0] = 1;
            Array.Copy(digits, 0, result, 1, size);

            return result;
        }
    }
}
