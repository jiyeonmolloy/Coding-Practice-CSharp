using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P824GoatLatinTest {
        [TestMethod]
        public void ToGoatLatinTest () {
            Assert.AreEqual("Imaa peaksmaaa oatGmaaaa atinLmaaaaa", P824GoatLatin.ToGoatLatin("I speak Goat Latin"));
            Assert.AreEqual("heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa", P824GoatLatin.ToGoatLatin("The quick brown fox jumped over the lazy dog"));
            Assert.AreEqual("obiesTmaa leepingSmaaa", P824GoatLatin.ToGoatLatin("Tobies Sleeping"));
        }
    }
}
