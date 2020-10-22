using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P74SearchA2DMatrixTest {
        [TestMethod]
        public void SearchMatrixTest () {
            Assert.IsTrue(P74SearchA2DMatrix.SearchMatrix(new int[][] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 50 } }, 3));
            Assert.IsFalse(P74SearchA2DMatrix.SearchMatrix(new int[][] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 50 } }, 13));
            Assert.IsFalse(P74SearchA2DMatrix.SearchMatrix(new int[][] { }, 0));
            Assert.IsTrue(P74SearchA2DMatrix.SearchMatrix(new int[][] { new[] { 1 } }, 1));
        }
    }
}
