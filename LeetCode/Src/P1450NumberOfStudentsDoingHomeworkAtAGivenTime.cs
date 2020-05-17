using System.Linq;

namespace LeetCode.Src {
    class P1450NumberOfStudentsDoingHomeworkAtAGivenTime {
        /// <summary>
        /// P1450 Number of Students Doing Homework at a Given Time. href = https://leetcode.com/problems/number-of-students-doing-homework-at-a-given-time/
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="queryTime"></param>
        /// <returns></returns>
        public static int BusyStudent (int[] startTime, int[] endTime, int queryTime) {
            int busyStudent = 0;

            for (int i = 0; i < startTime.Count(); i++) {
                if (startTime[i] > queryTime) {
                    continue;
                } else {
                    if (endTime[i] >= queryTime) {
                        busyStudent++;
                    }
                }
            }

            return busyStudent;
        }
    }
}
