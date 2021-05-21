using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // ---
            var a = 1;

            // change to 2 in pr1
            var b = 1;

            // uncomment in pr2
            Assert.AreEqual(2, a + b);
            
            // wait for both pr validation build
            // merge pr1
            // merge pr2
        }
    }
}
