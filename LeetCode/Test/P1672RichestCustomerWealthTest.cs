using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1672RichestCustomerWealthTest {
        [TestMethod]
        public void MaximumWealthTest () {
            Assert.AreEqual(10, P1672RichestCustomerWealth.MaximumWealth(new int[][] { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } }));
        }
    }
}
