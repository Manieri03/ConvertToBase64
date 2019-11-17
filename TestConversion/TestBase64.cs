using LibraryMethodConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestConversion
{
    [TestClass]
    public class TestBase64
    {
        [TestMethod]
        public void TestMethod1()
        {
            string r = Base64class.Base64();
            Assert.AreEqual("Q2lhbw==", r);
        }
    }
}
