using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace LeetCode.Test {
    [TestClass]
    public class P56MergenIntervalsTest {
        [TestMethod]
        public void MergeTest () {
            int[][] input = new[] { new[] { 1, 4 }, new[] { 1, 2 }, new[] { 15, 18 }, new[] { 2, 6 }, new[] { 8, 10 } };
            int[][] expected = new[] { new[] { 1, 6 }, new[] { 8, 10 }, new[] { 15, 18 } };
            P56MergenIntervals.Merge(input).Should().Equals(expected);

            input = new[] { new[] { 1, 4 }, new[] { 4, 5 } };
            expected = new[] { new[] { 1, 5 } };
            P56MergenIntervals.Merge(input).Should().Equals(expected);

            input = new[] { new[] { 1, 4 }, new[] { 0, 4 } };
            expected = new[] { new[] { 0, 4 } };
            P56MergenIntervals.Merge(input).Should().Equals(expected);
        }
    }
}
