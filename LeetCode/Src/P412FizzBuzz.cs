using System;
using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P412 Fizz Buzz
    ///  href = https://leetcode.com/problems/fizz-buzz/
    /// </summary>
    class P412FizzBuzz {
        public static IList<string> FizzBuzz (int n) {
            IList<string> fizzBuzzList = new List<string>();
            bool divisibleByThree, divisibleByFive;
            string fizzBuzz;

            for (int i = 1; i < n + 1; i++) {
                divisibleByThree = i % 3 == 0;
                divisibleByFive = i % 5 == 0;
                fizzBuzz = String.Empty;

                if (divisibleByThree) {
                    fizzBuzz = "Fizz";
                }

                if (divisibleByFive) {
                    fizzBuzz += "Buzz";
                }

                fizzBuzzList.Add(String.IsNullOrEmpty(fizzBuzz) ? i.ToString() : fizzBuzz);
            }

            return fizzBuzzList;
        }
    }
}
