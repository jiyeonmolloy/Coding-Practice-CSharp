using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1566 Detect Pattern of Length M Repeated K or MoreTimes
    ///  href = https://leetcode.com/problems/detect-pattern-of-length-m-repeated-k-or-more-times/
    /// </summary>
    class P1566DetectPatternOfLengthMRepeatedKOrMoreTimes {
        public static bool ContainsPattern (int[] arr, int m, int k) {
            int startIndex = 0;
            int index = 0;
            int patterns = 1;

            // Slow..
            List<int> list = arr.ToList();
            List<int> current = new List<int> { };
            List<int> target = new List<int> { };

            target = list.GetRange(startIndex, m);
            index = m;
            current = list.GetRange(index, m);
            while (index < arr.Length) {
                if (Enumerable.SequenceEqual(target, current)) {
                    patterns++;

                    if (patterns == k) {
                        return true;
                    }

                    index += m;

                    if (index + m > arr.Length) {
                        break;
                    }
                } else {
                    patterns = 1;
                    startIndex++;
                    index = startIndex + m;

                    if (startIndex + m > arr.Length) {
                        break;
                    }

                    if (index + m > arr.Length) {
                        break;
                    }

                    target = list.GetRange(startIndex, m);
                }

                current = list.GetRange(index, m);
            }

            return false;
        }
    }
}
