using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab1_3.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Validation.isInputValid(""), false);
            Assert.AreEqual(Validation.isInputValid("1"), false);
            Assert.AreEqual(Validation.isInputValid("11"), false);
            Assert.AreEqual(Validation.isInputValid("111"), false);
            Assert.AreEqual(Validation.isInputValid("1111"), true);
            Assert.AreEqual(Validation.isInputValid("-1111"), false);
            Assert.AreEqual(Validation.isInputValid("0000"), false);
            Assert.AreEqual(Validation.isInputValid("aaaa"), false);
        }
    }
}