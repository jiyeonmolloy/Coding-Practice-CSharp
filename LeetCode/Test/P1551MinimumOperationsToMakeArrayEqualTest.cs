using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1551MinimumOperationsToMakeArrayEqualTest {
        [TestMethod]
        public void MinOperationsTest () {
            // odd
            Assert.AreEqual(6, P1551MinimumOperationsToMakeArrayEqual.MinOperations(5));
            Assert.AreEqual(12, P1551MinimumOperationsToMakeArrayEqual.MinOperations(7));
            Assert.AreEqual(2, P1551MinimumOperationsToMakeArrayEqual.MinOperations(3));
            Assert.AreEqual(0, P1551MinimumOperationsToMakeArrayEqual.MinOperations(1));
            // even
            Assert.AreEqual(1, P1551MinimumOperationsToMakeArrayEqual.MinOperations(2));
            Assert.AreEqual(9, P1551MinimumOperationsToMakeArrayEqual.MinOperations(6));
            Assert.AreEqual(16, P1551MinimumOperationsToMakeArrayEqual.MinOperations(8));
        }
    }
}
