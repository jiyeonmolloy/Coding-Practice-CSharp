using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P165CompareVersionNumbersTest {
        [TestMethod]
        public void CompareVersionTest () {
            Assert.AreEqual(-1, P165CompareVersionNumbers.CompareVersion("0.1", "1.1"));
            Assert.AreEqual(1, P165CompareVersionNumbers.CompareVersion("1.0.1", "1"));
            Assert.AreEqual(-1, P165CompareVersionNumbers.CompareVersion("7.5.2.4", "7.5.3"));
            Assert.AreEqual(0, P165CompareVersionNumbers.CompareVersion("1.01", "1.001"));
            Assert.AreEqual(0, P165CompareVersionNumbers.CompareVersion("1.0", "1.0.0"));
        }
    }
}
