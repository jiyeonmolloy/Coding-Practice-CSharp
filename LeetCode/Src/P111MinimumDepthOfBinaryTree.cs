using System;
using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P111 Minimum Depth Of Binary Tree
    ///  href = https://leetcode.com/problems/minimum-depth-of-binary-tree/
    /// </summary>
    class P111MinimumDepthOfBinaryTree : TreeNode {
        public static int MinDepth (TreeNode root) {
            if (root == null) {
                return 0;
            } else if (root.left == null && root.right == null) {
                return 1;
            } else if (root.left == null) {
                return MinDepth(root.right) + 1;
            } else if (root.right == null) {
                return MinDepth(root.left) + 1;
            }

            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
    }
}
