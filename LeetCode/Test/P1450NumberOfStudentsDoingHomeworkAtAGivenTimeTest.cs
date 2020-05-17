using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1450NumberOfStudentsDoingHomeworkAtAGivenTimeTest {
        [TestMethod]

        public void FindNumberOfStudentsDoingHomeworkAtAGivenTime () {
            int[] startTime = new int[3] { 1, 2, 3 };
            int[] endTime = new int[3] { 3, 2, 7 };
            int queryTime = 4;

            Assert.AreEqual(1, P1450NumberOfStudentsDoingHomeworkAtAGivenTime.BusyStudent(startTime, endTime, queryTime));

            startTime = new int[1] { 4 };
            endTime = new int[1] { 4 };
            queryTime = 4;

            Assert.AreEqual(1, P1450NumberOfStudentsDoingHomeworkAtAGivenTime.BusyStudent(startTime, endTime, queryTime));

            startTime = new int[9] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            endTime = new int[9] { 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            queryTime = 5;

            Assert.AreEqual(5, P1450NumberOfStudentsDoingHomeworkAtAGivenTime.BusyStudent(startTime, endTime, queryTime));
        }

        [TestMethod]
        public void NoStudentsDoingHomeworkAtAGivenTime () {
            int[] startTime = new int[1] { 4 };
            int[] endTime = new int[1] { 4 };
            int queryTime = 5;

            Assert.AreEqual(0, P1450NumberOfStudentsDoingHomeworkAtAGivenTime.BusyStudent(startTime, endTime, queryTime));
        }
    }
}
