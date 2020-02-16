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
                new List<string> { "757", "777", "7" }),
                new List<string> { "757" }
            );
        }
    }
}
