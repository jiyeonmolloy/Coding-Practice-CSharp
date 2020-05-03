using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode {
    [TestClass]
    public class P202HappyNumberTest {
        [TestMethod]
        public void IsHappyNumber () {
            Assert.IsTrue(P202HappyNumber.IsHappy(19));
        }

        [TestMethod]
        public void IsNotHappyNumber () {
            Assert.IsFalse(P202HappyNumber.IsHappy(182));
        }
    }
}
