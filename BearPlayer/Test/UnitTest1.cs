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
            Bear_Player player = new Bear_Player();
            player.pictureBox1_Click(null, null);
            Assert.AreEqual(player.play, false);
        }
    }
}
