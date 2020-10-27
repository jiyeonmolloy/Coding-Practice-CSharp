using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Test {
    [TestClass]
    public class P1630ArithmeticSubarraysTest {
        [TestMethod]
        public void CheckArithmeticSubarraysTest () {
            IList<bool> expected = new List<bool>() { true, false, true };
            Assert.IsTrue(expected.SequenceEqual(P1630ArithmeticSubarrays.CheckArithmeticSubarrays(new[] { 4, 6, 5, 9, 3, 7 }, new[] { 0, 0, 2 }, new[] { 2, 3, 5 })));

            expected = new List<bool>() { false, true, false, false, true, true };
            Assert.IsTrue(expected.SequenceEqual(P1630ArithmeticSubarrays.CheckArithmeticSubarrays(new[] { -12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10 }, new[] { 0, 1, 6, 4, 8, 7 }, new[] { 4, 4, 9, 7, 9, 10 })));

            expected = new List<bool>() { true, true, true, true, false, true, true, true, true };
            Assert.IsTrue(expected.SequenceEqual(P1630ArithmeticSubarrays.CheckArithmeticSubarrays(new[] { -3, -6, -8, -4, -2, -8, -6, 0, 0, 0, 0 }, new[] { 5, 4, 3, 2, 4, 7, 6, 1, 7 }, new[] { 6, 5, 6, 3, 7, 10, 7, 4, 10 })));
        }
    }
}
