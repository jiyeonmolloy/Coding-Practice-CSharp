
namespace LeetCode.Src {
    class P1442CountTripletsThatCanFormTwoArraysOfEqualXOR {
        /// <summary>
        /// P1442 Count Triplets That Can Form Two Arrays Of Equal XOR. href = https://leetcode.com/problems/count-triplets-that-can-form-two-arrays-of-equal-xor/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int CountTriplets (int[] arr) {
            int count = 0;
            int a, b;
            int length = arr.Length;

            for (int i = 0; i < length; i++) {
                for (int j = i + 1; j < length; j++) {
                    if (i < j) {
                        a = PerformXOROnArray(i, j, arr);
                        for (int k = j; k < length; k++) {
                            if (j <= k) {
                                b = PerformXOROnArray(j, k + 1, arr);

                                if (a == b) {
                                    count++;
                                }
                            }
                        }
                    }
                }
            }

            return count;
        }

        private static int PerformXOROnArray (int start, int end, int[] arr) {
            int output = 0;
            for (int i = start; i < end; i++) {
                output ^= arr[i];
            }
            return output;
        }
    }
}
