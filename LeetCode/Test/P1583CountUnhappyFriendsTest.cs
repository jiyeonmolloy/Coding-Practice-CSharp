using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1583CountUnhappyFriendsTest {
        [TestMethod]
        public void UnhappyFriendsTest () {
            int[][] input = {
                new[] { 1, 2, 3 },
                new[] { 3, 2, 0 },
                new[] { 3, 1, 0 },
                new[] { 1, 2, 0 }
            };
            int[][] friends = {
                new[] { 0, 1 },
                new[] { 2, 3 }
            };

            Assert.AreEqual(2, P1583CountUnhappyFriends.UnhappyFriends(4, input, friends));

            input = new[] {
                new[] { 1 },
                new[] { 0 }
            };
            friends = new[] {
                new[] { 1, 0 }
            };

            Assert.AreEqual(0, P1583CountUnhappyFriends.UnhappyFriends(2, input, friends));

            input = new[] {
                new[] { 1, 3, 2 },
                new[] { 2, 3, 0 },
                new[] { 1, 3, 0 },
                new[] { 0, 2, 1 }
            };
            friends = new[] {
                new[] { 1, 3 },
                new[] { 0, 2 }
            };

            Assert.AreEqual(4, P1583CountUnhappyFriends.UnhappyFriends(4, input, friends));

            input = new[] {
                new[] { 1, 3, 2 },
                new[] { 2, 3, 0 },
                new[] { 1,0,3 },
                new[] { 1,0,2 }
            };
            friends = new[] {
                new [] { 2, 1 },
                new [] { 3, 0 }
            };

            Assert.AreEqual(0, P1583CountUnhappyFriends.UnhappyFriends(4, input, friends));
        }
    }
}
