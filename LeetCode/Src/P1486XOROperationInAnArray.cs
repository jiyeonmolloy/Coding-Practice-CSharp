
namespace LeetCode.Src {
    /// <summary>
    /// P1486 XOR Operation in an Array
    ///  href = https://leetcode.com/problems/xor-operation-in-an-array/
    /// </summary>
    class P1486XOROperationInAnArray {
        public static int XorOperation (int n, int start) {
            int output = 0;

            for (int i = 0; i < n; i++) {
                output ^= start + 2 * i;
            }

            return output;
        }
    }
}
