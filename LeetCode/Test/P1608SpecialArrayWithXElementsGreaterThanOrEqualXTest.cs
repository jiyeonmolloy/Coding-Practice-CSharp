using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1608SpecialArrayWithXElementsGreaterThanOrEqualXTest {
        [TestMethod]
        public void SpecialArrayTest () {
            Assert.AreEqual(3, P1608SpecialArrayWithXElementsGreaterThanOrEqualX.SpecialArray(new int[5] { 0, 4, 3, 0, 4 }));
            Assert.AreEqual(2, P1608SpecialArrayWithXElementsGreaterThanOrEqualX.SpecialArray(new int[2] { 3, 5 }));
            Assert.AreEqual(-1, P1608SpecialArrayWithXElementsGreaterThanOrEqualX.SpecialArray(new int[2] { 0, 0 }));
        }
    }
}
