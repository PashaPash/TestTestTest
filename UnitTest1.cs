using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // some1
            var a = 1;

            // some2
            var b = 1;

            // assert
            Assert.AreEqual(2, a + b);
        }
    }
}
