using System;
using BearPlayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var player = new BearPlayer.BearPlayer();
            player.pictureBox1_Click(null, null);
            Assert.AreEqual(player.play, false);
        }
    }
}
