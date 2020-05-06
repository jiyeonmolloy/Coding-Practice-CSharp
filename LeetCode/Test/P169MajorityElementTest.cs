using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P169MajorityElementTest {
        [TestMethod]
        public void FindMajorityElement () {
            int[] test = new int[3] { 3, 2, 3 };
            Assert.AreEqual(3, P169MajorityElement.MajorityElement(test));

            test = new int[7] { 2, 2, 1, 1, 1, 2, 2 };
            Assert.AreEqual(2, P169MajorityElement.MajorityElement(test));
        }
    }
}
