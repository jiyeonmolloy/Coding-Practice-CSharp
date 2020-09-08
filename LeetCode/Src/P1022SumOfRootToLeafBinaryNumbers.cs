using System;
using System.Collections.Generic;
using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P1022 Sum Of Root To Leaf Binary Numbers
    ///  href = https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/
    /// </summary>
    class P1022SumOfRootToLeafBinaryNumbers : TreeNode {
        public static int SumRootToLeaf (TreeNode root) {
            IList<string> binaryList = new List<string>();
            int sum = 0;

            Dfs(root, String.Empty, binaryList);

            foreach (string binary in binaryList) {
                sum += Convert.ToInt32(binary, 2);
            }

            return sum;
        }

        private static void Dfs (TreeNode root, string value, IList<string> binary) {
            if (root == null) {
                return;
            }
            if (root.left == null && root.right == null) { // If leaf node
                binary.Add(value + root.val.ToString());
                return;
            }

            value += root.val.ToString();

            Dfs(root.left, value, binary);
            Dfs(root.right, value, binary);
        }
    }
}
