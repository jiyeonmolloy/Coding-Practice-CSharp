using System.Collections.Generic;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace LeetCode.Test {
    [TestClass]
    public class P118PascalsTriangleTest {
        [TestMethod]
        public void GenerateTest () {
            IList<IList<int>> expectedTriangle = new List<IList<int>>(){
                new List<int>(){ 1 },
                new List<int>(){ 1, 1 },
                new List<int>(){ 1, 2, 1 },
                new List<int>(){ 1, 3, 3, 1 },
                new List<int>(){ 1, 4, 6, 4, 1 },
            };

            expectedTriangle.Should().BeEquivalentTo(P118PascalsTriangle.Generate(5));
        }
    }
}
