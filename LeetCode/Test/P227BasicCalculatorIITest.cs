using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P227BasicCalculatorIITest {
        [TestMethod]
        public void CalculateTest () {
            Assert.AreEqual(7, P227BasicCalculatorII.Calculate("3+2*2"));
            Assert.AreEqual(1, P227BasicCalculatorII.Calculate(" 3/2 "));
            Assert.AreEqual(5, P227BasicCalculatorII.Calculate(" 3+5 / 2 "));
        }
    }
}
