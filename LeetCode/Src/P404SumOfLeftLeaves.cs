using System;
using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P404 Sum Of Left Leaves
    ///  href = https://leetcode.com/problems/sum-of-left-leaves/
    /// </summary>
    class P404SumOfLeftLeaves {
        public static int SumOfLeftLeaves (TreeNode root) {
            if (root == null) {
                return 0;
            }

            int leftCount = SumOfLeftLeaf(root.left, true);
            int rightCount = SumOfLeftLeaf(root.right, false);

            return leftCount + rightCount;
        }

        private static int SumOfLeftLeaf (TreeNode root, Boolean isLeftLeaf) {
            if (root == null) {
                return 0;
            }

            if (root.left == null && root.right == null && isLeftLeaf) {
                return root.val;
            }

            int leftCount = SumOfLeftLeaf(root.left, true);
            int rightCount = SumOfLeftLeaf(root.right, false);

            return leftCount + rightCount;
        }
    }
}
