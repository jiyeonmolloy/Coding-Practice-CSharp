using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P389FindTheDifferenceTest {
        [TestMethod]
        public void FindTheDifferenceTest () {
            Assert.AreEqual('e', P389FindTheDifference.FindTheDifference("abcd", "abcde"));
        }
    }
}
