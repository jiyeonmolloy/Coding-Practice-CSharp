using System;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P468 Validate IP Address
    ///  href = https://leetcode.com/problems/validate-ip-address/
    /// </summary>
    class P468ValidateIPAddress {
        public static string ValidIPAddress (string IP) {
            if (IP.Contains('.')) {
                return IsIPv4(IP) ? "IPv4" : "Neither";
            }

            if (IP.Contains(':')) {
                return IsIPv6(IP) ? "IPv6" : "Neither";
            }

            return "Neither";
        }

        private static bool IsIPv4 (string IP) {
            // valid IPv4?
            // four decimal numbers, 0 - 255
            // separated by dots ;)
            // leading zeros are invalid

            char delimiter = '.';

            if (IP[0] == delimiter || IP[IP.Length - 1] == delimiter) {
                return false;
            }

            string[] addresses = IP.Split(delimiter);

            if (addresses.Length != 4) {
                return false;
            }

            int addressValue;
            foreach (string address in addresses) {
                if (int.TryParse(address, out addressValue)) {
                    if (addressValue > 255) {
                        return false;
                    }
                    if ((addressValue < 10 && address.Length > 1) ||
                               (addressValue < 100 && address.Length > 2)) {
                        return false;
                    }
                } else {
                    return false;
                }
            }

            return true;
        }

        private static bool IsIPv6 (string IP) {
            // eight groups of four hex digits
            // each group representing 16 bits
            // separated by colons! ;)
            // leading zeroes are all good
            // consecutive colons are invalid

            char delimiter = ':';

            if (IP[0] == delimiter || IP[IP.Length - 1] == delimiter) {
                return false;
            }

            string[] addresses = IP.Split(delimiter);

            if (addresses.Length != 8) {
                return false;
            }

            bool isDigit, isHexLetter;
            foreach (string address in addresses) {
                if (address == String.Empty || address.Length > 4) {
                    return false;
                }

                foreach (char c in address.ToLower()) {
                    isDigit = c >= '0' && c <= '9';
                    isHexLetter = c >= 'a' && c <= 'f';
                    if (!(isDigit || isHexLetter)) {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
