
namespace LeetCode.Src {
    /// <summary>
    /// P1551 Minimum Operations To Make Array Equal 
    ///  href = https://leetcode.com/problems/minimum-operations-to-make-array-equal/
    /// </summary>
    class P1551MinimumOperationsToMakeArrayEqual {
        public static int MinOperations (int n) {
            int middleIndex = n / 2;
            if (n % 2 == 1) {
                // if n is odd
                return middleIndex * middleIndex + middleIndex;
            }

            // if n is even
            middleIndex -= 1;
            return middleIndex * (middleIndex + 1) + middleIndex + 1;
        }
    }
}
