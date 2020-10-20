using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1625LexicographicallySmallestStringAfterApplyingOperationsTest {
        [TestMethod]
        public void FindLexSmallestStringTest () {
            P1625LexicographicallySmallestStringAfterApplyingOperations operations = new P1625LexicographicallySmallestStringAfterApplyingOperations();
            Assert.AreEqual("2050", operations.FindLexSmallestString("5525", 9, 2));
            Assert.AreEqual("24", operations.FindLexSmallestString("74", 5, 1));
            Assert.AreEqual("0011", operations.FindLexSmallestString("0011", 4, 2));
        }
    }
}
