using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P700SearchInABinarySearchTree
    ///  href = https://leetcode.com/problems/search-in-a-binary-search-tree/
    /// </summary>
    class P700SearchInABinarySearchTree : TreeNode {
        public static TreeNode SearchBST (TreeNode root, int val) {
            while (root != null) {
                if (root.val == val) {
                    return root;
                }

                if (root.val > val) {
                    root = root.left;
                } else if (root.val < val) {
                    root = root.right;
                }
            }

            return null;
        }
    }
}
