using System;
using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P104 Maximum Depth Of Binary Tree
    /// href = https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    class P104MaximumDepthOfBinaryTree : TreeNode {
        public static int MaxDepth (TreeNode root) {
            if (root == null) {
                return 0;
            } else if (root.left == null && root.right == null) {
                return 1;
            } else if (root.left == null) {
                return MaxDepth(root.right) + 1;
            } else if (root.right == null) {
                return MaxDepth(root.left) + 1;
            }

            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }
}
