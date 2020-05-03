using System.Collections.Generic;
using System.Linq;


namespace LeetCode.Src {
    /// <summary>
    /// P238 Product of Array Except Self. href = https://leetcode.com/problems/product-of-array-except-self/
    /// Key: Prefix Sum
    /// </summary>
    class P238ProductOfArrayExceptSelf {
        public int[] ProductExceptSelf (int[] nums) {
            int size = nums.Length;
            int[] prefixProducts = CalculatePrefixProduct(nums);
            int[] suffixProducts = CalculateSuffixProducts(nums);


            int[] output = new int[size];
            for (int i = 0; i < size; i++) {
                output[i] = prefixProducts[i] * suffixProducts[i + 1];
            }

            return output;
        }

        internal int[] CalculateSuffixProducts (int[] nums) {
            int size = nums.Length;
            int[] suffixProducts = new int[size + 1];

            suffixProducts[size] = 1;
            for (int i = size - 1; i >= 0; --i) {
                suffixProducts[i] = suffixProducts[i + 1] * nums[i];
            }

            return suffixProducts;
        }

        internal int[] CalculatePrefixProduct (int[] nums) {
            List<int> prefixProducts = new List<int>() { 1 };

            foreach (int num in nums) {
                prefixProducts.Add(prefixProducts.LastOrDefault() * num);
            }

            return prefixProducts.ToArray();
        }
    }
}
