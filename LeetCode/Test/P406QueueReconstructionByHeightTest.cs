using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace LeetCode.Test {
    [TestClass]
    public class P406QueueReconstructionByHeightTest {
        [TestMethod]
        public void ReconstructQueueTest () {
            int[][] input = new int[6][] { new int[2] { 7, 0 }, new int[2] { 4, 4 }, new int[2] { 7, 1 }, new int[2] { 5, 0 }, new int[2] { 6, 1 }, new int[2] { 5, 2 } };
            int[][] expected = new int[6][] { new int[2] { 5, 0 }, new int[2] { 7, 0 }, new int[2] { 5, 2 }, new int[2] { 6, 1 }, new int[2] { 4, 4 }, new int[2] { 7, 1 } };

            P406QueueReconstructionByHeight.ReconstructQueue(input).Should().Equals(expected);
        }
    }
}
