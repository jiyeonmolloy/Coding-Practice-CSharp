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
using NHibernate.Hql.Ast.ANTLR.Tree;

namespace CodingPractice.Test {
    [TestClass]
    public class WeeklyChallenge : TreeNode {

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
