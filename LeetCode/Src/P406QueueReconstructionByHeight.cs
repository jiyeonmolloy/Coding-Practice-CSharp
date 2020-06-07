using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    class P406QueueReconstructionByHeight {
        /// <summary>
        /// P406 Queue Reconstruction By Height. href = https://leetcode.com/problems/queue-reconstruction-by-height/
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public static int[][] ReconstructQueue (int[][] people) {
            const int HEIGHT = 0;
            const int PEOPLE_INFRONT = 1;
            List<int[]> reconstruct = new List<int[]>();
            IOrderedEnumerable<int[]> sorted = people.ToList().OrderByDescending(x => x[HEIGHT]).ThenBy(x => x[PEOPLE_INFRONT]);

            foreach (int[] person in sorted) {
                reconstruct.Insert(person[PEOPLE_INFRONT], person);
            }

            return reconstruct.ToArray();
        }
    }
}
