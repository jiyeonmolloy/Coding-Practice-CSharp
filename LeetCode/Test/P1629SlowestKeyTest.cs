using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1629SlowestKeyTest {
        [TestMethod]
        public void SearchTest () {
            Assert.AreEqual('c', P1629SlowestKey.SlowestKey(new[] { 9, 29, 49, 50 }, "cbcd"));
            Assert.AreEqual('a', P1629SlowestKey.SlowestKey(new[] { 12, 23, 36, 46, 62 }, "spuda"));
        }
    }
}
