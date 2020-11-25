using System;
using System.Collections;

namespace LeetCode.Src {
    /// <summary>
    ///  P227 Basic Calculator II
    ///  href = https://leetcode.com/problems/basic-calculator-ii/
    /// </summary>
    class P227BasicCalculatorII {
        public static int Calculate (string s) {
            if (string.IsNullOrEmpty(s)) {
                return 0;
            }

            Stack numStack = new Stack();
            int number = 0;
            int calculated = 0;
            char target;
            char operation = '+';
            for (int i = 0; i < s.Length; i++) {
                target = s[i];
                if (Char.IsDigit(target)) {
                    number = number * 10 + (target - '0');
                }

                if (!Char.IsDigit(target) && !Char.IsWhiteSpace(target) || i == s.Length - 1) {
                    if (operation == '+') {
                        calculated = number;
                    } else if (operation == '-') {
                        calculated = -number;
                    } else if (operation == '*') {
                        calculated = (int)numStack.Pop() * number;
                    } else if (operation == '/') {
                        calculated = (int)numStack.Pop() / number;
                    }
                    numStack.Push(calculated);
                    operation = target;
                    number = 0;
                }
            }

            int result = 0;
            while (numStack.Count > 0) {
                result += (int)numStack.Pop();
            }

            return result;
        }
    }
}
