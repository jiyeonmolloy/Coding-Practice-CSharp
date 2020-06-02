using LeetCode.Src.Common;

namespace LeetCode.Src {
    class P1008ConstructBSTFromPreorderTraversal : TreeNode {
        /// <summary>
        /// P1008 Construct Binary Search Tree from Preorder Traversal. href = https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/
        /// </summary>
        /// <param name="preorder"></param>
        /// <returns></returns>
        public static TreeNode BstFromPreorder (int[] preorder) {
            TreeNode root = new TreeNode(preorder[0]);

            for (int i = 1; i < preorder.Length; i++) {
                InsertNode(root, preorder[i]);
            }

            return root;
        }

        private static void InsertNode (TreeNode root, int value) {
            TreeNode current = root;
            TreeNode parent = null;

            while (current != null) {
                parent = current;
                current = current.val > value ? current.left : current.right;
            }

            if (parent.val > value) {
                parent.left = new TreeNode(value);
            } else {
                parent.right = new TreeNode(value);
            }
        }
    }
}
