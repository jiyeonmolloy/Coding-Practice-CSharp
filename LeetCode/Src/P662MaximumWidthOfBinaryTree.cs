using System.Collections.Generic;
using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P662 Maximum Width of Binary Tree
    ///  href = https://leetcode.com/problems/maximum-width-of-binary-tree/
    /// </summary>
    class P662MaximumWidthOfBinaryTree : TreeNode {
        private class CustomNode {
            public int Position;
            public TreeNode Node;

            public CustomNode(TreeNode node, int position) {
                Node = node;
                Position = position;
            }
        }

        public static int WidthOfBinaryTree (TreeNode root) {
                if (root == null) {
                    return 0;
                }

                Queue<CustomNode> queue = new Queue<CustomNode>();
                CustomNode customNode = new CustomNode(root, 1);

                queue.Enqueue(customNode);

                CustomNode node;
                int maxWidth = 0;
                int firstPosition, lastPosition;
                int currentLevelWidth, position;
                int size;

                while (queue.Count > 0) {
                    size = queue.Count;
                    firstPosition = 0;
                    lastPosition = 0;

                    // Compute each level of Binary Tree
                    for (int i = 0; i < size; i++) {
                        node = queue.Dequeue();
                        position = node.Position;

                        if (i == 0) {
                            firstPosition = position;
                        }

                        if (i == size - 1) {
                            lastPosition = position;
                        }

                        if (node.Node.left != null) {
                            queue.Enqueue(new CustomNode(node.Node.left, 2 * position - 1));
                        }

                        if (node.Node.right != null) {
                            queue.Enqueue(new CustomNode(node.Node.right, 2 * position));
                        }
                    }

                    currentLevelWidth = lastPosition - firstPosition + 1;
                    maxWidth = currentLevelWidth > maxWidth ? currentLevelWidth : maxWidth;
                }

                return maxWidth;
            }
        }
}

