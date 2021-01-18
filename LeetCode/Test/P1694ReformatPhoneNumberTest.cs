using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1694ReformatPhoneNumberTest {
        [TestMethod]
        public void ReformatNumberTest () {
            Assert.AreEqual("123-456-78", P1694ReformatPhoneNumber.ReformatNumber("123 4-5678"));
            Assert.AreEqual("175-229-353-94-75", P1694ReformatPhoneNumber.ReformatNumber("--17-5 229 35-39475 "));
        }
    }
}
