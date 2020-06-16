using System;
using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace LeetCode.Test {
    [TestClass]
    public class P468ValidateIPAddressTest {
        [TestMethod]
        public void ValidIPAddressTest () {
            Assert.AreEqual("IPv4", P468ValidateIPAddress.ValidIPAddress("172.16.254.1"));
            Assert.AreEqual("Neither", P468ValidateIPAddress.ValidIPAddress("172.16.254.01"));
            Assert.AreEqual("IPv6", P468ValidateIPAddress.ValidIPAddress("2001:0db8:85a3:0:0:8A2E:0370:7334"));
            Assert.AreEqual("Neither", P468ValidateIPAddress.ValidIPAddress("2001:0db8:85a3::8A2E:0370:7334"));
            Assert.AreEqual("Neither", P468ValidateIPAddress.ValidIPAddress("256.256.256.256"));
            Assert.AreEqual("Neither", P468ValidateIPAddress.ValidIPAddress("12.12.12"));
        }
    }
}
