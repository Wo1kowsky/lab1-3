using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab1_3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(Logic.FilterNumbers(
                new List<string> { }),
                new List<string> { }
            );

            CollectionAssert.AreEqual(Logic.FilterNumbers(
                new List<string> { "" }),
                new List<string> { }
            );

            CollectionAssert.AreEqual(Logic.FilterNumbers(
               new List<string> { "577" }),
               new List<string> { "577" }
           );

            CollectionAssert.AreEqual(Logic.FilterNumbers(
                new List<string> { "7777" }),
                new List<string> { }
            );

            CollectionAssert.AreEqual(Logic.FilterNumbers(
                new List<string> { "7877", "7777", "7777" }),
                new List<string> { }
            );

            CollectionAssert.AreEqual(Logic.FilterNumbers(
                new List<string> { "7677" }),
                new List<string> { "7677" }
            );

            CollectionAssert.AreEqual(Logic.FilterNumbers(
                new List<string> { "7577", "7777", "7777" }),
                new List<string> { "7577" }
            );

            CollectionAssert.AreEqual(Logic.FilterNumbers(
                new List<string> { "7776", "7777", "7776" }),
                new List<string> { "7776", "7776" }
            );

            CollectionAssert.AreEqual(Logic.FilterNumbers(
                new List<string> { "8888", "7777", "7776" }),
                new List<string> { "7776" }
            );

            CollectionAssert.AreEqual(Logic.FilterNumbers(
                new List<string> { "8888", "7777", "7776", "0000", "1234", "1237" }),
                new List<string> { "7776", "1237" }
            );

            CollectionAssert.AreEqual(Logic.FilterNumbers(
                new List<string> { "8888", "7777", "7776", "0000", "1234", "1237", "8888", "7777", "7776", "0000", "1248", "1247" }),
                new List<string> { "7776", "1237", "7776", "1247" }
            );
        }
    }
}
