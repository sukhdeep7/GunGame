using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GunGameTest
{
    [TestClass]
    public class UnitTest1
    {
        GunGame.Logic gg = new GunGame.Logic();
        [TestMethod]
        public void TestMethod1()
        {
            int ggResult = gg.Spinning();
            Assert.IsTrue(ggResult > 0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int ggResult2 = gg.ShootingAway();
            Assert.IsTrue(ggResult2 > 0);
        }
    }
}
