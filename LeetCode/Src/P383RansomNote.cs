using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P383 Ransom Note. href = https://leetcode.com/problems/ransom-note/
    /// </summary>
    class P383RansomNote {
        public static bool CanConstruct (string ransomNote, string magazine) {
            List<char> magazineList = magazine.ToCharArray().ToList();

            foreach (char ransomNoteChar in ransomNote) {
                if (magazineList.Contains(ransomNoteChar)) {
                    magazineList.Remove(ransomNoteChar);
                } else {
                    return false;
                }
            }
            return true;
        }
    }
}
