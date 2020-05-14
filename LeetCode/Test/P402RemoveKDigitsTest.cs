using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P402RemoveKDigitsTest {
        [TestMethod]
        public void FindSmallestNumberByRemovingKDigits () {
            string num = "1432219";
            int k = 3;
            Assert.AreEqual("1219", P402RemoveKDigits.RemoveKdigits(num, k));

            num = "14";
            k = 2;
            Assert.AreEqual("0", P402RemoveKDigits.RemoveKdigits(num, k));

            num = "10200";
            k = 1;
            Assert.AreEqual("200", P402RemoveKDigits.RemoveKdigits(num, k));

            num = "10";
            k = 2;
            Assert.AreEqual("0", P402RemoveKDigits.RemoveKdigits(num, k));

            num = "112";
            k = 1;
            Assert.AreEqual("11", P402RemoveKDigits.RemoveKdigits(num, k));

            num = "10";
            k = 1;
            Assert.AreEqual("0", P402RemoveKDigits.RemoveKdigits(num, k));

            num = "100";
            k = 1;
            Assert.AreEqual("0", P402RemoveKDigits.RemoveKdigits(num, k));

            num = "5337";
            k = 2;
            Assert.AreEqual("33", P402RemoveKDigits.RemoveKdigits(num, k));

            num = "212";
            k = 1;
            Assert.AreEqual("12", P402RemoveKDigits.RemoveKdigits(num, k));
        }
    }
}
