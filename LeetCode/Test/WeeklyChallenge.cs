using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using Cassandra.DataStax.Graph;
using System.Globalization;
using LeetCode.Src.Common;

namespace CodingPractice.Test {
    [TestClass]
    public class WeeklyChallenge : TreeNode{
        [TestMethod]
        public void MaySevenTest () { // todo
            TreeNode treeNode = new TreeNode(1, new TreeNode(2, new TreeNode(3)), new TreeNode(4));

            Assert.IsFalse(IsCousins(treeNode, 4, 3));
        }

        public bool IsCousins (TreeNode root, int x, int y) {
            // Edge cases
            if (root.left == null || root.right == null) { // only two nodes in the tree
                return false;
            } else if (root.val == x || root.val == x) { // x matches the root node
                return false;
            } else if (root.val == y || root.val == y) { // y matches the root node
                return false;
            }

            // Recursive DFS 
            // Ignore null nodes! Aha :)

            var visited = new HashSet<Vertex>();
            int searchNode = x > y ? y : x;
            int depth = 0;
            int xDepth = 0;
            int yDepth = 0;

            TreeNode current = root;
            TreeNode xParent = null;
            TreeNode yParent = null;

            return true;
        }

        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode (int val = 0, TreeNode left = null, TreeNode right = null) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
