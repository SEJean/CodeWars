using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace KataTests
{
    [TestClass]
    public class Level4Katas
    {
        /// <summary>
        /// Challenge URL : https://www.codewars.com/kata/ip-validation/
        /// </summary>
        [TestMethod]
        public void TestIpValidation()
        {

            string[] validIpString = new string[]
            {
                "127.1.23.41",
                "255.255.255.255",
                "254.254.254.254",
            };

            string[] invalidStrings = new string[]
            {
                "123.456.78.90",
                "123.045.067.089",
                "-1.-1.-1.1",
                "     ",
                "abcpsd2",
                "12.3.53.f",

            };

            for (int i = 0; i < validIpString.Length; i++)
            {
                Assert.IsTrue(Kata.is_valid_IP(validIpString[i]));
            }

            for (int i = 0; i < invalidStrings.Length; i++)
            {
                Assert.IsFalse(Kata.is_valid_IP(invalidStrings[i]));
            }
            
        }
    }
}
