
namespace LeetCode.Src {
    /// <summary>
    /// P1512 Number of Good Pairs
    ///  href = https://leetcode.com/problems/number-of-good-pairs/
    /// </summary>
    class P1512NumberOfGoodPairs {
        public static int NumIdenticalPairs (int[] nums) {
            int targetValue, targetIndex;
            int pairs = 0;
            for (int i = 0; i < nums.Length; i++) {
                targetIndex = i;
                targetValue = nums[targetIndex];

                for (int j = targetIndex + 1; j < nums.Length; j++) {
                    if (targetValue == nums[j]) {
                        pairs++;
                    }
                }
            }

            return pairs;
        }
    }
}
