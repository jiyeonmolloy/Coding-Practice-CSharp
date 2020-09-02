using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P217ContainsDuplicateTest {
        [TestMethod]
        public void ContainsDuplicateTest () {
            Assert.IsTrue(P217ContainsDuplicate.ContainsDuplicate(new int[4] {1,2,3,1}));
            Assert.IsFalse(P217ContainsDuplicate.ContainsDuplicate(new int[4] { 1, 2, 3, 4 }));
        }
    }
}
