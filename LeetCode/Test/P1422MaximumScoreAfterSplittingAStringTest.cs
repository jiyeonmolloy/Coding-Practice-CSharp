using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1422MaximumScoreAfterSplittingAStringTest {
        [TestMethod]
        public void MaximumScore () {
            Assert.AreEqual(5, P1422MaximumScoreAfterSplittingAString.MaxScore("011101"));
            Assert.AreEqual(5, P1422MaximumScoreAfterSplittingAString.MaxScore("00111"));
            Assert.AreEqual(3, P1422MaximumScoreAfterSplittingAString.MaxScore("1111"));
        }
    }
}
