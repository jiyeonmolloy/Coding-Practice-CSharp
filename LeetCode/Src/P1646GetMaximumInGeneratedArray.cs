
namespace LeetCode.Src {
    /// <summary>
    /// P1646 Get Maximum In Generated Array
    ///  href = https://leetcode.com/problems/get-maximum-in-generated-array/
    /// </summary>
    class P1646GetMaximumInGeneratedArray {
        public static int GetMaximumGenerated (int n) {
            if (n == 0) {
                return 0;
            } else if (n == 1) {
                return 1;
            }

            int max = 1;
            int index = 1;
            int current = 0;
            int[] nums = new int[n + 1];
            nums[0] = 0;
            nums[1] = 1;
            while (current <= n) {
                current = 2 * index;
                if (current <= n) {
                    nums[current] = nums[index];
                    if (nums[current] > max) {
                        max = nums[current];
                    }
                }

                current = 2 * index + 1;
                if (current <= n) {
                    nums[current] = nums[index] + nums[index + 1];
                    if (nums[current] > max) {
                        max = nums[current];
                    }
                }
                index++;
            }

            return max;
        }
    }
}
