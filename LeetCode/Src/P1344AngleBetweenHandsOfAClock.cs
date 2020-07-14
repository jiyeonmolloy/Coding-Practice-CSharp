using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1344 Angle Between Hands of a Clock
    ///  href = https://leetcode.com/problems/angle-between-hands-of-a-clock/
    /// </summary>
    class P1344AngleBetweenHandsOfAClock {
        public static double AngleClock (int hour, int minutes) {
            double minuteAngle = minutes * 6;
            double hourAngle = CalculateHourAngle(hour, minutes);
            double difference = Math.Abs(minuteAngle - hourAngle); ;

            return difference > 180 ? (360 - difference) : difference;
        }

        private static double CalculateHourAngle (int hour, int minutes) {
            hour = hour == 12 ? 0 : hour;
            return hour * 30 + 0.5 * minutes;
        }
    }
}
