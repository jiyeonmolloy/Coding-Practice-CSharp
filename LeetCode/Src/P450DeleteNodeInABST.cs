using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P450 Delete Node In a BST
    ///  href = https://leetcode.com/problems/delete-node-in-a-bst/
    /// </summary>
    class P450DeleteNodeInABST : TreeNode {
        public static TreeNode DeleteNode (TreeNode root, int key) {
            if (root == null) {
                return null;
            }

            if (root.val > key) { // traverse left node
                root.left = DeleteNode(root.left, key);
            } else if (root.val < key) { // traverse right node
                root.right = DeleteNode(root.right, key);
            } else { // found the node to delete!
                if (root.left == null && root.right == null) { // If leaf node, no change is required
                    return null;
                }

                if (root.right == null) { // node with single left node
                    return root.left;
                }

                if (root.left == null) { // node with single right node
                    return root.right;
                }

                // node with left and right node
                root.val = FindMinNode(root.right);
                root.right = DeleteNode(root.right, root.val);
            }

            return root;
        }

        private static int FindMinNode (TreeNode root) {
            int minValue = root.val;

            while (root.left != null) {
                minValue = root.left.val;
                root = root.left;
            }

            return minValue;
        }
    }
}
