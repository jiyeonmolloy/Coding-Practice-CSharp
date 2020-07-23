
namespace LeetCode.Src {
    /// <summary>
    /// P260 Single Number III
    ///  href = https://leetcode.com/problems/single-number-iii/
    /// </summary>
    class P260SingleNumberIII {
        public static int[] SingleNumber (int[] nums) {
            int length = nums.Length;
            int xorSum = 0;

            foreach (int num in nums) {
                xorSum ^= num;
            }

            int bitOffset = 1;
            while ((xorSum & bitOffset) == 0) {
                bitOffset <<= 1;
            }

            int firstNumber = 0, secondNumber = 0;
            foreach (int num in nums) {
                if ((num & bitOffset) > 0) {
                    firstNumber ^= num;
                } else {
                    secondNumber ^= num;
                }
            }

            return new int[2] { firstNumber, secondNumber };
        }
    }
}
