using System.Collections.Generic;
using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    ///  P938 Range Sum Of BST
    ///  href = https://leetcode.com/problems/range-sum-of-bst/
    /// </summary>
    class P938RangeSumOfBST : TreeNode {
        private int sum = 0;
        public int RangeSumBSTDfs (TreeNode root, int low, int high) {
            Dfs(root, low, high);
            return sum;
        }

        private void Dfs (TreeNode root, int low, int high) {
            if (root == null) return;

            int current = root.val;
            if (current >= low && current <= high) {
                sum += current;
            }

            if (current > low) {
                Dfs(root.left, low, high);
            }

            if (current < high) {
                Dfs(root.right, low, high);
            }
        }

        public int RangeSumBSTIterative (TreeNode root, int low, int high) {
            int sum = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            TreeNode current;
            int currentValue;
            while (stack.Count > 0) {
                current = stack.Pop();
                currentValue = current.val;

                if (currentValue >= low && currentValue <= high) {
                    sum += currentValue;
                }

                if (currentValue > low && current.left != null) {
                    stack.Push(current.left);
                }

                if (currentValue < high && current.right != null) {
                    stack.Push(current.right);
                }
            }

            return sum;
        }
    }
}
