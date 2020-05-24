using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1456MaximumNumberOfVowelsInASubstringOfGivenLengthTest {
        [TestMethod]
        public void MaximumNumberOfVowelsInASubstringOfGivenLength () {
            Assert.AreEqual(3, P1456MaximumNumberOfVowelsInASubstringOfGivenLength.MaxVowels("abciiidef", 3));
            Assert.AreEqual(2, P1456MaximumNumberOfVowelsInASubstringOfGivenLength.MaxVowels("aeiou", 2));
            Assert.AreEqual(2, P1456MaximumNumberOfVowelsInASubstringOfGivenLength.MaxVowels("leetcode", 3));
            Assert.AreEqual(0, P1456MaximumNumberOfVowelsInASubstringOfGivenLength.MaxVowels("rhythms", 4));
            Assert.AreEqual(1, P1456MaximumNumberOfVowelsInASubstringOfGivenLength.MaxVowels("tryhard", 4));
            Assert.AreEqual(4, P1456MaximumNumberOfVowelsInASubstringOfGivenLength.MaxVowels("weallloveyou", 7));
        }
    }
}
