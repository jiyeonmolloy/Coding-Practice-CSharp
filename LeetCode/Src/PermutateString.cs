using System;
using System.Linq;

namespace CodingPractice.Src {
    class PermutateString {
        internal string Permutate (string s) {
            if (s.Length == 1) {
                // If string only contains one character, output string input
                return s;
            } else if (!CanPermutate(s)) {
                return String.Empty;
            }

            // Get all the digits
            Char[] digits = s.ToCharArray().Where(y => Char.IsDigit(y)).ToArray();
            // Get all the characters
            Char[] characters = s.ToCharArray().Where(y => Char.IsLetter(y)).ToArray();

            // Perform permutation
            string output = String.Empty;
            if (digits.Length > characters.Length) {
                output = CombineArray(characters, digits);
                output += digits[digits.Length - 1];
            } else if (characters.Length > digits.Length) {
                output = CombineArray(digits, characters);
                output += characters[characters.Length - 1];
            } else {
                output = CombineArray(digits, characters);
            }

            return output;
        }

        internal string CombineArray (Char[] smallerArray, Char[] largerArray) {
            string output = String.Empty;
            for (int i = 0; i < smallerArray.Length; i++) {
                output += largerArray[i];
                output += smallerArray[i];
            }
            return output;
        }

        internal bool CanPermutate (string s) {
            int digitCount = s.Count(x => Char.IsDigit(x));
            int charCount = s.Length - digitCount;

            if (!s.Any(char.IsDigit) || !s.Any(char.IsLetter)) {
                // Check if there are a combination of digits and characters
                return false;
            } else if (digitCount >= charCount + 2 || digitCount <= charCount - 2) {
                // Check if there are enough digits and strings to perform permutations
                return false;
            } else {
                return true;
            }
        }
    }
}
