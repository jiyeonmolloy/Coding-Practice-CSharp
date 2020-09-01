using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P949LargestTimeForGivenDigitsTest {
        [TestMethod]
        public void LargestTimeFromDigitsTest () {
            Assert.AreEqual("23:41", P949LargestTimeForGivenDigits.LargestTimeFromDigits(new int[4] { 1, 2, 3, 4 }));
            Assert.AreEqual("", P949LargestTimeForGivenDigits.LargestTimeFromDigits(new int[4] { 5, 5, 5, 5 }));
            Assert.AreEqual("00:00", P949LargestTimeForGivenDigits.LargestTimeFromDigits(new int[4] { 0, 0, 0, 0 }));
            Assert.AreEqual("10:00", P949LargestTimeForGivenDigits.LargestTimeFromDigits(new int[4] { 0, 0, 1, 0 }));
            Assert.AreEqual("04:00", P949LargestTimeForGivenDigits.LargestTimeFromDigits(new int[4] { 0, 0, 4, 0 }));
            Assert.AreEqual("11:11", P949LargestTimeForGivenDigits.LargestTimeFromDigits(new int[4] { 1, 1, 1, 1 })); // Favourite time :)
        }
    }
}
