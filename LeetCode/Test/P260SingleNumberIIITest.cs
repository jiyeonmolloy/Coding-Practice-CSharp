using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P260SingleNumberIIITest {
        [TestMethod]
        public void SingleNumberTest () {
            CollectionAssert.AreEqual(new int[2] { 3, 5 }, P260SingleNumberIII.SingleNumber(new int[6] { 1, 2, 1, 3, 2, 5 }));
        }
    }
}
