using System.Collections.Generic;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace LeetCode.Test {
    [TestClass]
    public class P46PermutationsTest {
        [TestMethod]
        public void PermuteTest () {
            IList<IList<int>> permutations = new List<IList<int>>() {
                new List<int>() {1, 2, 3},
                new List<int>() {1, 3, 2},
                new List<int>() {2, 1, 3},
                new List<int>() {2, 3, 1},
                new List<int>() {3, 1, 2},
                new List<int>() {3, 2, 1},
            };

            permutations.Should().BeEquivalentTo(P46Permutations.Permute(new[] { 1, 2, 3 }));
        }
    }
}
