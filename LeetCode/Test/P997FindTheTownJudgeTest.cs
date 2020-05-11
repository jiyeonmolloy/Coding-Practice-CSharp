using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P997FindTheTownJudgeTest {
        [TestMethod]
        public void FindTownJudgeTest () {
            int[][] trust = new int[1][] { new int[2] { 1, 2 } };
            Assert.AreEqual(2, P997FindTheTownJudge.FindJudge(2, trust));

            trust = new int[2][] { new int[2] { 1, 3 }, new int[2] { 2, 3 } };
            Assert.AreEqual(3, P997FindTheTownJudge.FindJudge(3, trust));

            trust = new int[3][] { new int[2] { 1, 3 }, new int[2] { 2, 3 }, new int[2] { 3, 1 } };
            Assert.AreEqual(-1, P997FindTheTownJudge.FindJudge(3, trust));

            trust = new int[2][] { new int[2] { 1, 2 }, new int[2] { 2, 3 } };
            Assert.AreEqual(-1, P997FindTheTownJudge.FindJudge(3, trust));

            trust = new int[5][] { new int[2] { 1, 3 }, new int[2] { 1, 4 }, new int[2] { 2, 3 }, new int[2] { 2, 4 }, new int[2] { 4, 3 } };
            Assert.AreEqual(3, P997FindTheTownJudge.FindJudge(4, trust));
        }
    }
}
