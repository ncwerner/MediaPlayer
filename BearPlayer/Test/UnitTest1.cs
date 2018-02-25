using System;
using System.Windows.Forms;
using BearPlayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class GUI_Test
    {
        [TestMethod]
        public void Test_PlayButton()
        {
            // Arrange
            Bear_Player player = new Bear_Player();

            // Act
            player.Change_Play_State();

            // Assert
            Assert.IsFalse(player.play);
        }

        [TestMethod]
        public void Test_PauseButton()
        {
            // Arrange 
            Bear_Player player = new Bear_Player();

            // Act
            player.Change_Play_State();
            player.Change_Play_State();

            // Assert 
            Assert.IsTrue(player.play);
        }

        [TestMethod]
        public void Test_PlayPicture()
        {
            // Arrange 
            Bear_Player player = new Bear_Player();

            // Act
            String address = player.Get_Picture(1);

            // Assert
            Assert.AreEqual(address, "\\playButton1.png");
        }

        [TestMethod]
        public void Test_PausePicture()
        {
            // Arrange 
            Bear_Player player = new Bear_Player();

            // Act
            String address = player.Get_Picture(0);

            // Assert
            Assert.AreEqual(address, "\\pauseButton.png");
        }



    }
}
