using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1640CheckArrayFormationThroughConcatenationTest {
        [TestMethod]
        public void CanFormArrayTest () {
            Assert.IsTrue(P1640CheckArrayFormationThroughConcatenation.CanFormArray(new[] { 91, 4, 64, 78 }, new int[][] { new[] { 78 }, new[] { 4, 64 }, new[] { 91 } }));
            Assert.IsTrue(P1640CheckArrayFormationThroughConcatenation.CanFormArray(new[] { 85 }, new int[][] { new[] { 85 } }));
            Assert.IsTrue(P1640CheckArrayFormationThroughConcatenation.CanFormArray(new[] { 15, 85 }, new int[][] { new[] { 85 }, new[] { 15 } }));
            Assert.IsFalse(P1640CheckArrayFormationThroughConcatenation.CanFormArray(new[] { 49, 18, 16 }, new int[][] { new[] { 16, 18, 49 } }));
            Assert.IsFalse(P1640CheckArrayFormationThroughConcatenation.CanFormArray(new[] { 1, 3, 5, 7 }, new int[][] { new[] { 2, 4, 6, 8 } }));
        }
    }
}
