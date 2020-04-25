using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode {
    [TestClass]
    public class HappyNumberTest {
        [TestMethod]
        public void IsHappyNumber () {
            Assert.IsTrue(HappyNumber.IsHappy(19));
        }

        [TestMethod]
        public void IsNotHappyNumber () {
            Assert.IsFalse(HappyNumber.IsHappy(182));
        }
    }
}
