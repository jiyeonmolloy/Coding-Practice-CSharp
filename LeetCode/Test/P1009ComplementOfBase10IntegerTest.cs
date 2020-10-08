using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1009ComplementOfBase10IntegerTest {
        [TestMethod]
        public void BitwiseComplementTest () {
            Assert.AreEqual(2, P1009ComplementOfBase10Integer.BitwiseComplement(5)); 
            Assert.AreEqual(0, P1009ComplementOfBase10Integer.BitwiseComplement(7));
            Assert.AreEqual(5, P1009ComplementOfBase10Integer.BitwiseComplement(10));
        }
    }
}
