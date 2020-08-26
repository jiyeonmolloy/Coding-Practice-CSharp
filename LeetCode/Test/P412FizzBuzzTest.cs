using System.Collections.Generic;
using System.Linq;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P412FizzBuzzTest {
        [TestMethod]
        public void FizzBuzzTest () {
            IList<string> expectedResponse = new List<string>() {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz" };
            Assert.IsTrue(expectedResponse.SequenceEqual(P412FizzBuzz.FizzBuzz(15)));
        }
    }
}
