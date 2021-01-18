using System;
using System.Text.RegularExpressions;

namespace LeetCode.Src {
    /// <summary>
    /// P1694 Reformat Phone Number
    /// href = https://leetcode.com/problems/reformat-phone-number/
    /// </summary>
    class P1694ReformatPhoneNumber {
        public static string ReformatNumber (string number) {
            number = number.Replace('-', ' ');
            number = Regex.Replace(number, @"\s+", "");
            int size = number.Length;

            if (size < 4) {
                return number;
            }

            int count = 0;
            string output = String.Empty;
            int lastDigits = size % 3;

            if (lastDigits == 1) {
                lastDigits = 4;
            }

            int formatIndex = size - lastDigits + 1;
            for (int i = 0; i < size; i++) {
                if (i >= formatIndex && lastDigits == 4) {
                    if (count == 2) {
                        output += "-" + number[i].ToString();
                        count = 1;
                    } else {
                        output += number[i].ToString();
                        count++;
                    }
                } else {
                    if (count == 3) {
                        output += "-" + number[i].ToString();
                        count = 1;
                    } else {
                        output += number[i].ToString();
                        count++;
                    }
                }
            }

            return output;
        }
    }
}
