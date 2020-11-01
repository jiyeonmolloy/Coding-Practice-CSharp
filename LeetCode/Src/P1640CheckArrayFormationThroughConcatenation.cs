using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P1640 Check Array Formation Through Concatenation
    ///  href = https://leetcode.com/problems/check-array-formation-through-concatenation/
    /// </summary>
    class P1640CheckArrayFormationThroughConcatenation {
        public static bool CanFormArray (int[] arr, int[][] pieces) {
            int rows = pieces.Length;
            Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>(rows);

            int target;
            int key;
            int cols;
            for (int i = 0; i < rows; i++) {
                key = pieces[i][0];
                dictionary[key] = new List<int>();
                cols = pieces[i].Length;
                for (int j = 1; j < cols; j++) {
                    target = pieces[i][j];
                    dictionary[key].Add(target);
                }
            }

            int arrayValue;
            int dictValue;
            int arrayIndex = 0;
            while (arrayIndex < arr.Length) {
                target = arr[arrayIndex];
                if (!dictionary.ContainsKey(target)) {
                    return false;
                }

                int index = 0;
                int innerIndex = arrayIndex + 1;
                while (index < dictionary[target].Count) {
                    arrayValue = arr[innerIndex];
                    dictValue = dictionary[target][index];

                    if (!arrayValue.Equals(dictValue)) {
                        return false;
                    }

                    index++;
                    innerIndex++;
                }

                arrayIndex = innerIndex;
            }


            return true;
        }
    }
}
