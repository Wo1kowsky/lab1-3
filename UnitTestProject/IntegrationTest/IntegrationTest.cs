using System;
using System.Collections.Generic;
using lab1_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.IntegrationTest
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void CheckFilterNumbersFull()
        {
            List<string> list = new List<string>() { "8888", "7777", "7776", "1234", "1237" };
            Assert.AreEqual(list.TrueForAll(
                Validation.isInputValid), 
                true);
            CollectionAssert.AreEqual(
                Logic.FilterNumbers(list),
                new List<string> { "7776", "1237" }
            );
        }
    }
}
