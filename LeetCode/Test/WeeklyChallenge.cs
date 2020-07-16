using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using Cassandra.DataStax.Graph;
using System.Globalization;
using LeetCode.Src.Common;
using System.Linq.Expressions;
using NHibernate.Hql.Ast;
using NHibernate.Id.Insert;
using FluentAssertions;
using Newtonsoft.Json.Serialization;
using System.Collections.Specialized;
using Cassandra;
using NHibernate.Hql.Ast.ANTLR.Tree;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NHibernate.Linq.Functions;

namespace CodingPractice.Test {
    [TestClass]
    public class WeeklyChallenge : TreeNode {
        [TestMethod]
        public void MyPowTest () {
            Assert.AreEqual(0.00000, MyPow(2.00000, -2147483648), 0.00000001);
            Assert.AreEqual(1024.00000, MyPow(2.00000, 10), 0.00000001);
            Assert.AreEqual(9.26100, MyPow(2.10000, 3), 0.00000001);
            Assert.AreEqual(0.25000, MyPow(2.00000, -2), 0.00000001);
        }

        public double MyPow (double x, int n) {
            if (n == 0) {
                return 1;
            }

            long power = n;
            if (power < 0) {
                x = 1 / x;
                power = -power;
            }

            double result = 1;
            double target = x;
            for (long i = power; i > 0; i /= 2) {
                if (i % 2 == 1) { 
                    result *= target;
                }

                target *= target;
            }

            return result;
        }

        [TestMethod]
        public void ReverseWordsTest () {
            Assert.AreEqual("world! hello", ReverseWords("  hello world!  "));
            Assert.AreEqual("great the will", ReverseWords("will the   great"));
            Assert.AreEqual("friday on donuts", ReverseWords("donuts  on    friday  "));
        }

        public string ReverseWords (string s) {
            List<string> wordArray = s.Trim().Split(' ').Where(w => !string.IsNullOrEmpty(w)).ToList();
            string reversed = String.Empty;

            for (int i = wordArray.Count - 1; i >= 0; i--) {
                if (i != 0) {
                    reversed += wordArray[i] + " ";
                } else {
                    reversed += wordArray[i]; // last word
                }
            }

            return reversed;
        }

        [TestMethod]
        public void AngleClockTest () {
            Assert.AreEqual(165, AngleClock(12, 30));
            Assert.AreEqual(75, AngleClock(3, 30));
            Assert.AreEqual(7.5, AngleClock(3, 15));
            Assert.AreEqual(155, AngleClock(4, 50));
            Assert.AreEqual(0, AngleClock(12, 0));
            Assert.AreEqual(76.50000, AngleClock(1, 57));
        }

        public double AngleClock (int hour, int minutes) {
            double minuteAngle = minutes * 6;
            double hourAngle = CalculateHourAngle(hour, minutes);
            double difference = Math.Abs(minuteAngle - hourAngle); ;

            return difference > 180 ? (360 - difference) : difference;
        }

        private double CalculateHourAngle(int hour, int minutes) {
            hour = hour == 12 ? 0 : hour;
            return hour * 30 + 0.5 * minutes;
        }

        [TestMethod]
        public void SolveGoTest () {
            // Assert.AreEqual(2, ClimbStairs(2));
            // Assert.AreEqual(3, ClimbStairs(3));

            char[][] smallBoard = new char[4][] {
                new char[4] {'X', 'X', 'X', 'X'}, 
                new char[4] {'X', 'O', 'O', 'X'}, 
                new char[4] {'X', 'X', 'O', 'X'},
                new char[4] {'X', 'O', 'X', 'X'}
            };

            Solve(null);

            Solve(smallBoard);

            char[][] bigBoard = new char[6][] {
                new char[6] {'X', 'X', 'X', 'X', 'X', 'X'},
                new char[6] {'X', 'X', 'X', 'X', 'X', 'X'},
                new char[6] {'X', 'X', 'X', 'X', 'X', 'X'},
                new char[6] {'X', 'X', 'X', 'X', 'X', 'X'},
                new char[6] {'X', 'X', 'X', 'X', 'X', 'X'},
                new char[6] {'X', 'X', 'X', 'X', 'X', 'X'}
            };
        }

        public void Solve (char[][] board) {
            if (board == null) {
                return;
            }

            int colCount = board[0].GetLength(0);
            int rowCount = board.GetLength(0);

            if (colCount < 3 || rowCount < 3) {
                return;
            }
            
            // look in the middle section
            // edge case: four corners
            // otherwise just check once

            int upperCol = colCount - 2;
            int upperRow = rowCount - 2;

            int targetCol, targetRow;
            for (int i = 1; i < rowCount - 1; i++) {

                if (i == 1 || i == upperRow) {
                    // Set to boundary if we are in valid region
                    targetRow = i == 1 ? 0 : i;
                    targetRow = targetRow == upperRow ? upperRow + 1 : i;

                    for (int j = 1; j < colCount - 1; j++) {
                        if ((j == 1 || j == upperCol) && board[i][j] == 'O') {
                            // Set to boundary if we are in valid region
                            targetCol = j == 1 ? 0 : j;
                            targetCol = targetCol == upperCol ? upperCol + 1 : j;

                            // corner? check both contacts
                            if (i == 1 && j == 1) { // top left
                                if (board[0][1] == 'X' && board[1][0] == 'X') {
                                    board[i][j] = 'X';
                                    continue;
                                }
                            } else if (i == 1 && j == upperCol) { // top right
                                if (board[0][upperCol] == 'X' && board[1][targetCol] == 'X') {
                                    board[i][j] = 'X';
                                    continue;
                                }
                            } else if (i == upperRow && j == 1) { // bottom left
                                if (board[upperRow][0] == 'X' && board[targetRow][1] == 'X') {
                                    board[i][j] = 'X';
                                    continue;
                                }
                            } else if (i == upperRow && j == upperCol) { // bottom right
                                if (board[upperRow][targetCol] == 'X' && board[targetRow][upperCol] == 'X') {
                                    board[i][j] = 'X';
                                    continue;
                                }
                            }


                            // if not corner, check if surrounded
                            if (board[targetRow][targetCol] == 'X') {
                                board[i][j] = 'X';
                            }
                        }
                    }
                }
            }
        }

        private bool IsCorner(int row, int col, int upperRow, int upperCol) {
            return true;
        }

        [TestMethod]
        public void ClimbingChairsTest () {
            Assert.AreEqual(2, ClimbStairs(2));
            Assert.AreEqual(3, ClimbStairs(3));
        }

        public int ClimbStairs (int n) { // Understanding
            int stepOne = 0;
            int stepTwo = 1;
            int distinctWays = 0;

            for (int i = 1; i <= n; i++) {
                distinctWays = stepOne + stepTwo;
                stepOne = stepTwo;
                stepTwo = distinctWays;
            }

            return distinctWays;
        }
    }
}
