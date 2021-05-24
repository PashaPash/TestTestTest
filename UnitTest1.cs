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

            // change from 1 to 2 in pr1
            var b = 1;

            // uncomment in master
            // Assert.AreEqual(2, a + b); 
            
            // wait for both pr validation build
            // merge pr1
            // merge pr2
        }
    }
}
