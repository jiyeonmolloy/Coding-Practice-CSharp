using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1486XOROperationInAnArrayTest {
        [TestMethod]
        public void XorOperationTest () {
            Assert.AreEqual(8, P1486XOROperationInAnArray.XorOperation(5, 0));
            Assert.AreEqual(8, P1486XOROperationInAnArray.XorOperation(4, 3));
            Assert.AreEqual(7, P1486XOROperationInAnArray.XorOperation(1, 7));
            Assert.AreEqual(2, P1486XOROperationInAnArray.XorOperation(10, 5));
        }
    }
}
