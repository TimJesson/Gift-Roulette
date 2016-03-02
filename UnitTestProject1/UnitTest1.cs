using System;
using Gift_Roulette;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestRandom()
        {
            var test = new Gifts();
            Random Random = new Random();
            test.randGen = Random.Next(1, 7);
            Assert.IsTrue(test.randGen >= 1 & test.randGen < 7);
        }

        public void GiftWin()
        {
            var test = new Gifts();
            test.count = 2;
            int expectedCount = 2;
            Assert.AreEqual(expectedCount, test.count);

        }
    }
}
