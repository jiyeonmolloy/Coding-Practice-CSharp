using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P238ProductOfArrayExceptSelfTest {
        [TestMethod]
        public void ProductExceptSelf () {
            int[] expected = { 24, 12, 8, 6 };
            int[] numbers = { 1, 2, 3, 4 };

            P238ProductOfArrayExceptSelf productOfArray = new P238ProductOfArrayExceptSelf();
            CollectionAssert.AreEqual(expected, productOfArray.ProductExceptSelf(numbers));
        }
    }
}
