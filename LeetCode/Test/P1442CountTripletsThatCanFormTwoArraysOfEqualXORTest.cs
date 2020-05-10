using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1442CountTripletsThatCanFormTwoArraysOfEqualXORTest {
        [TestMethod]
        public void CountTripletsThatCanFormTwoArraysOfEqualXOR () {
            int[] test = new int[5] { 2, 3, 1, 6, 7 };
            Assert.AreEqual(4, P1442CountTripletsThatCanFormTwoArraysOfEqualXOR.CountTriplets(test));

            test = new int[5] { 1, 1, 1, 1, 1 };
            Assert.AreEqual(10, P1442CountTripletsThatCanFormTwoArraysOfEqualXOR.CountTriplets(test));

            test = new int[2] { 2, 3 };
            Assert.AreEqual(0, P1442CountTripletsThatCanFormTwoArraysOfEqualXOR.CountTriplets(test));

            test = new int[5] { 1, 3, 5, 7, 9 };
            Assert.AreEqual(3, P1442CountTripletsThatCanFormTwoArraysOfEqualXOR.CountTriplets(test));

            test = new int[9] { 7, 11, 12, 9, 5, 2, 7, 17, 22 };
            Assert.AreEqual(8, P1442CountTripletsThatCanFormTwoArraysOfEqualXOR.CountTriplets(test));
        }
    }
}
