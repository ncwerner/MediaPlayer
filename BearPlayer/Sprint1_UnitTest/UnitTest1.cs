using System;
using BearPlayer;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sprint1_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        /* TEST VARIABLES THAT SHOULD BE CHANGED BASED ON LOCAL DIRECTORY */
        String file_directory0 = @"C:\Users\calec\Music\Cities\02 - Godspeed.mp3";
        String file_directory1 = @"C:\Users\calec\Music\Europe\The Final Countdown\01 - The Final Countdown.mp3";
        String title = "Godspeed";
        String album = "Cities";
        String artist = "Anberlin";
        uint year = 2007;

        [TestMethod]
        public void PlayButton_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Change_PlayState();

            // Assert
            Assert.IsFalse(player.Get_Play());
        }

        [TestMethod]
        public void PauseButton_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Change_PlayState();
            player.Change_PlayState();

            // Assert
            Assert.IsTrue(player.Get_Play());
        }

        [TestMethod]
        public void PlayButton_StartsPlay_Test()
        {
            // Arrange 
            var player = new BearPlayer.BearPlayer();

            // Act

            // Assert
            Assert.IsTrue(player.Get_Play());
        }

        [TestMethod]
        public void PlayPicture_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            String result = player.Get_Picture(0);

            // Assert
            Assert.AreEqual(result, @"C:\BearPlayer\Resources\playButton1.png");
        }

        [TestMethod]
        public void PausePicture_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            String result = player.Get_Picture(1);

            // Assert
            Assert.AreEqual(result, @"C:\BearPlayer\Resources\pauseButton.png");
        }

        [TestMethod]
        public void ChangePicture_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            String result = player.Get_Picture(1);
            result = player.Get_Picture(0);

            // Assert
            Assert.AreEqual(result, @"C:\BearPlayer\Resources\playButton1.png");
        }

        [TestMethod]
        public void NullPicture_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            String result = player.Get_Picture(3);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void FolderPathNull_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act 

            // Assert
            Assert.IsNull(player.Get_FolderPath());
        }

        [TestMethod]
        public void FolderPath_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act 
            player.Set_FolderPath(@"C:\Users\calec\Music\Anberlin\Never Take Friendship Personal");

            // Assert
            Assert.AreEqual(player.Get_FolderPath(), @"C:\Users\calec\Music\Anberlin\Never Take Friendship Personal");
        }

        [TestMethod]
        public void ChangeFolderPath_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act 
            player.Set_FolderPath(@"C:\Users\calec\Music\Anberlin\Never Take Friendship Personal");
            player.Set_FolderPath(@"C:\Users\calec\Music\Genesis\Turn It on Again-The Hits [The Tour Edition] Disc 1");

            // Assert
            Assert.AreNotEqual(player.Get_FolderPath(), @"C:\Users\calec\Music\Anberlin\Never Take Friendship Personal");
            Assert.AreEqual(player.Get_FolderPath(), @"C:\Users\calec\Music\Genesis\Turn It on Again-The Hits [The Tour Edition] Disc 1");
        }

        [TestMethod]
        public void FilePathNull_Test()
        {
            // Arrage
            var player = new BearPlayer.BearPlayer();

            // Act 

            // Assert
            Assert.IsNull(player.Get_FilePath());
        }

        [TestMethod]
        public void FilePath_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act 
            player.Set_FilePath(@"‪C:\Users\calec\Music\Cities\02 - Godspeed.mp3");

            // Assert
            Assert.AreEqual(player.Get_FilePath(), @"‪C:\Users\calec\Music\Cities\02 - Godspeed.mp3");
        }

        [TestMethod]
        public void ChangeFilePath_Test()
        {
            // Arrange 
            var player = new BearPlayer.BearPlayer();

            // Act 
            player.Set_FilePath(@"‪C:\Users\calec\Music\Amazon MP3\Anberlin\Devotion\01-12-Ijsw.mp3");
            player.Set_FilePath(@"C:\Users\calec\Music\3 Doors Down\3 Doors Down\04 - Let Me Be Myself.mp3");

            // Assert 
            Assert.AreEqual(player.Get_FilePath(), @"C:\Users\calec\Music\3 Doors Down\3 Doors Down\04 - Let Me Be Myself.mp3");
            Assert.AreNotEqual(player.Get_FilePath(), @"‪C:\Users\calec\Music\Amazon MP3\Anberlin\Devotion\01-12-Ijsw.mp3");
        }

        [TestMethod]
        public void Get_Song_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Set_FilePath(file_directory0);
            TagLib.File file = TagLib.File.Create(player.Get_FilePath());
            string test_title = file.Tag.Title;

            // Assert
            Assert.AreEqual(test_title, title);
        }

        [TestMethod]
        public void Get_SongAlbum_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Set_FilePath(file_directory0);
            TagLib.File file = TagLib.File.Create(player.Get_FilePath());
            string test_album = file.Tag.Album;

            // Assert
            Assert.AreEqual(test_album, album);
        }

        [TestMethod]
        public void Get_SongArtist_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Set_FilePath(file_directory0);
            TagLib.File file = TagLib.File.Create(player.Get_FilePath());
            string test_artist = file.Tag.FirstAlbumArtist;
           
            // Assert
            Assert.AreEqual(test_artist, artist);
        }

        [TestMethod]
        public void Get_SongYear_Test()
        {
            // Arrange 
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Set_FilePath(file_directory0);
            TagLib.File file = TagLib.File.Create(player.Get_FilePath());
            uint test_year = file.Tag.Year;

            // Assert
            Assert.AreEqual(test_year, (uint)year);
        }

        [TestMethod]
        public void Change_Song_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Set_FilePath(file_directory1);
            TagLib.File file = TagLib.File.Create(player.Get_FilePath());

            player.Set_FilePath(file_directory0);
            file = TagLib.File.Create(player.Get_FilePath());
            string test_title = file.Tag.Title;

            // Assert
            Assert.AreEqual(test_title, title);
        }

        [TestMethod]
        public void Change_SongAlbum_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Set_FilePath(file_directory1);
            TagLib.File file = TagLib.File.Create(player.Get_FilePath());

            player.Set_FilePath(file_directory0);
            file = TagLib.File.Create(player.Get_FilePath());
            string test_album = file.Tag.Album;

            // Assert
            Assert.AreEqual(test_album, album);
        }

        [TestMethod]
        public void Change_SongArtist_Test()
        {
            // Arrange
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Set_FilePath(file_directory1);
            TagLib.File file = TagLib.File.Create(player.Get_FilePath());

            player.Set_FilePath(file_directory0);
            file = TagLib.File.Create(player.Get_FilePath());
            string test_artist = file.Tag.FirstAlbumArtist;

            // Assert
            Assert.AreEqual(test_artist, artist);
        }

        [TestMethod]
        public void Change_SongYear_Test()
        {
            // Arrange 
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Set_FilePath(file_directory1);
            TagLib.File file = TagLib.File.Create(player.Get_FilePath());

            player.Set_FilePath(file_directory0);
            file = TagLib.File.Create(player.Get_FilePath());
            uint test_year = file.Tag.Year;

            // Assert
            Assert.AreEqual(test_year, (uint)year);
        }

        [TestMethod]
        public void SongTitleNull_Test()
        {
            // Arrange 
            var player = new BearPlayer.BearPlayer();

            // Act

            // Assert 
            Assert.IsNull(player.Get_Song_Name());
        }

        [TestMethod]
        public void Set_SongTitle_Test()
        {
            // Arrange 
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Set_FilePath(file_directory0);
            TagLib.File file = TagLib.File.Create(player.Get_FilePath());
            player.Set_Song_Name(file.Tag.Title);

            // Assert
            Assert.AreEqual(player.Get_Song_Name(), title);
        }

        [TestMethod]
        public void Change_SongTitle_Test()
        {
            // Arrange 
            var player = new BearPlayer.BearPlayer();

            // Act
            player.Set_FilePath(file_directory1);
            TagLib.File file = TagLib.File.Create(player.Get_FilePath());
            player.Set_Song_Name(file.Tag.Title);

            player.Set_FilePath(file_directory0);
            file = TagLib.File.Create(player.Get_FilePath());
            player.Set_Song_Name(file.Tag.Title);

            // Assert
            Assert.AreEqual(player.Get_Song_Name(), title);
        }
    }
}
