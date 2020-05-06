using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P169 Majority Element. href = https://leetcode.com/problems/majority-element/
    /// </summary>
    class P169MajorityElement {
        public static int MajorityElement (int[] nums) {
            int majority = nums.Length / 2;
            int count;
            int analyzeInt;

            while (nums.Length > 0) {
                count = 1;
                analyzeInt = nums[0];
                for (int i = 1; i < nums.Length; i++) {
                    if (analyzeInt == nums[i]) {
                        count++;
                    }
                }

                if (count > majority) {
                    return analyzeInt;
                }

                nums = nums.Where(x => x != analyzeInt).ToArray();
            }


            return -1;
        }
    }
}
