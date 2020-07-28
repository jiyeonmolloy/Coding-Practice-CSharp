using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P621 Task Scheduler
    ///  href = https://leetcode.com/problems/task-scheduler/
    /// </summary>
    class P621TaskScheduler {
        public static int LeastInterval (char[] tasks, int n) {
            int totalNum = tasks.Length;
            if (n == 0) {
                return totalNum;
            }

            Dictionary<char, int> taskDict = new Dictionary<char, int>();
            foreach (char task in tasks) {
                if (taskDict.ContainsKey(task)) {
                    taskDict[task]++;
                } else {
                    taskDict.Add(task, 1);
                }
            }

            int[] charFreqPairs = taskDict.OrderBy(x => x.Value).Reverse().Select(x => x.Value).ToArray();

            int largestFreq = charFreqPairs[0];
            int coolDown = (largestFreq - 1) * n;

            int currentFreq;
            for (int i = 1; i < charFreqPairs.Length; i++) {
                currentFreq = charFreqPairs[i];
                if (currentFreq == largestFreq) {
                    coolDown -= currentFreq;
                    coolDown++;
                } else {
                    coolDown -= currentFreq;
                }
            }

            if (coolDown > 0) {
                return coolDown + totalNum;
            }

            return totalNum;
        }
    }
}
