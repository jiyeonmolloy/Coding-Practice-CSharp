using System;
using System.Collections;
using System.Text;

namespace LeetCode.Src {
    /// <summary>
    ///  P394 Decode String
    ///  href = https://leetcode.com/problems/decode-string/
    /// </summary>
    class P394DecodeString {
        public static string DecodeString (string s) {
            if (s.Length == 1) {
                return s;
            }

            Stack freqStack = new Stack();
            Stack seqStack = new Stack();
            char target;
            int freq = 0;
            int innerFreq;
            StringBuilder seqBuilder = new StringBuilder();
            StringBuilder innerSeqBuilder = new StringBuilder();
            foreach (char character in s) {
                target = character;

                if (Char.IsDigit(target)) {
                    freq = freq * 10 + (target - '0');

                } else if (Char.IsLetter(target)) {
                    seqBuilder.Append(target);

                } else if (target.Equals('[')) {
                    freqStack.Push(freq);
                    seqStack.Push(seqBuilder);
                    freq = 0;
                    seqBuilder = new StringBuilder();

                } else if (target.Equals(']')) {
                    innerSeqBuilder = seqBuilder;
                    innerFreq = (int)freqStack.Pop();
                    seqBuilder = (StringBuilder)seqStack.Pop();

                    for (int j = 0; j < innerFreq; j++) {
                        seqBuilder.Append(innerSeqBuilder);
                    }

                    freq = 0;
                }
            }

            return seqBuilder.ToString();
        }
    }
}
