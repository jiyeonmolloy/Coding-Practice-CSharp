using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P470ImplementRand10UsingRand7Test {
        [TestMethod]
        public void Rand7Test () {
            Assert.IsTrue(P470ImplementRand10UsingRand7.Rand10() < 11);
        }
    }
}
