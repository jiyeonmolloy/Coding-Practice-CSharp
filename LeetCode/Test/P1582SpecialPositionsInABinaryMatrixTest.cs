using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1582SpecialPositionsInABinaryMatrixTest {
        [TestMethod]
        public void NumSpecialTest () {
            int[][] input = new int[3][] {
                new int[3] { 1,0,0 },
                new int[3] { 0,0,1 },
                new int[3] { 1, 0, 0 }
            };
            Assert.AreEqual(1, P1582SpecialPositionsInABinaryMatrix.NumSpecial(input));

            input = new int[3][] {
                new int[3] { 1,0,0 },
                new int[3] { 0,1,0 },
                new int[3] { 0, 0, 1 }
            };
            Assert.AreEqual(3, P1582SpecialPositionsInABinaryMatrix.NumSpecial(input));

            input = new int[4][] {
                new int[4] { 0,0,0,1 },
                new int[4] { 1,0,0,0 },
                new int[4] { 0,1,1,0 },
                new int[4] { 0, 0, 0, 0 }
            };
            Assert.AreEqual(2, P1582SpecialPositionsInABinaryMatrix.NumSpecial(input));

            input = new int[5][] {
                new int[5] { 0,0,0,0,0 },
                new int[5] { 1,0,0,0,0 },
                new int[5] { 0,1,0,0,0 },
                new int[5] { 0, 0, 1, 0, 0 },
                new int[5] { 0,0,0,1,1 },
            };
            Assert.AreEqual(3, P1582SpecialPositionsInABinaryMatrix.NumSpecial(input));

            input = new int[5][] {
                new int[8] { 0,0,0,0,0,1,0,0 },
                new int[8] { 0,0,0,0,1,0,0,1 },
                new int[8] { 0,0,0,0,1,0,0,0},
                new int[8] { 1,0,0,0,1,0,0,0 },
                new int[8] { 0,0,1,1,0,0,0,0 }
            };
            Assert.AreEqual(1, P1582SpecialPositionsInABinaryMatrix.NumSpecial(input));
        }
    }
}
