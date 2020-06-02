using LeetCode.Src.Common;

namespace LeetCode.Src {
    class P226InvertBinaryTree : TreeNode{
        /// <summary>
        /// P226 Invert Binary Tree. href = https://leetcode.com/problems/invert-binary-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static TreeNode InvertTree (TreeNode root) {
            if (root == null) {
                return root;
            }

            // Invert left and right values
            TreeNode originalLeftValue = root.left;
            root.left = root.right;
            root.right = originalLeftValue;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}
