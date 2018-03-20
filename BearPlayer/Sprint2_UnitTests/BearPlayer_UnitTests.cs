using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sprint2_UnitTests
{
    [TestClass]
    public class BearPlayer_UnitTests
    {
        string file_path1 = @"C:\Users\calec\Music\Cities\02 - Godspeed.mp3";
        string file_path2 = @"C:\Users\calec\Music\Cities\04 - A Whisper & A Clamor.mp3";
        string file_path3 = @"C:\Users\calec\Music\Hans Zimmer\The Da Vinci Code\13 - Chevaliers De Sangreal.mp3";
        string file_path_duplicate = @"C:\Users\calec\Music\Anberlin\Cities\02 - Godspeed.mp3";

        [TestMethod]
        public void Test_Play_Song_New_Song()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
            bool result = player.play_song(file_path1);

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void Test_Play_Song_Another_New_Songs()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
            bool result = player.play_song(file_path1);
            result = player.play_song(file_path2);

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void Test_Play_Song_Same_Songs()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
            bool result = player.play_song(file_path1);
            result = player.play_song(file_path1);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void Test_Get_Song_Name()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);

            // Act
            string song_name = player.getSongName(file);


            // Assert
            Assert.AreEqual(song_name, "Godspeed");
        }


        [TestMethod]
        public void Test_Get_Album_Artist()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);

            // Act
            string song_name = player.getAlbumArtist(file);


            // Assert
            Assert.AreEqual(song_name, "Anberlin");
        }


        [TestMethod]
        public void Test_Get_Album()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);

            // Act
            string song_name = player.getAlbumName(file);


            // Assert
            Assert.AreEqual(song_name, "Cities");
        }


        [TestMethod]
        public void Test_List_Column_Info_Title()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);

            // Act
            ListViewItem item = player.List_Column_Info(ref file);
            string title = item.SubItems[0].Text.ToString();

            // Assert
            Assert.AreEqual(title, "Godspeed");            
        }


        [TestMethod]
        public void Test_List_Column_Info_Album()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);

            // Act
            ListViewItem item = player.List_Column_Info(ref file);
            string album = item.SubItems[1].Text.ToString();

            // Assert
            Assert.AreEqual(album, "Cities");
        }


        [TestMethod]
        public void Test_List_Column_Info_Artist()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);

            // Act
            ListViewItem item = player.List_Column_Info(ref file);
            string artist = item.SubItems[2].Text.ToString();

            // Assert
            Assert.AreEqual(artist, "Anberlin");
        }


        [TestMethod]
        // Test file where the first seconds digit is 0
        public void Test_List_Column_Info_Duration()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);

            // Act
            ListViewItem item = player.List_Column_Info(ref file);
            string duration = item.SubItems[3].Text.ToString();

            // Assert
            Assert.AreEqual(duration, "3:02");  
        }


        [TestMethod]
        // Test file where the first seconds digit is not 0
        public void Test_List_Column_Info_Duration2()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path2);

            // Act
            ListViewItem item = player.List_Column_Info(ref file);
            string duration = item.SubItems[3].Text.ToString();

            // Assert
            Assert.AreEqual(duration, "3:25");   // Test file where the first seconds digit is not 0
        }

        
        [TestMethod]
        public void Test_Song_Map()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
            player.add_new_song(file_path1);
            player.add_new_song(file_path2);
           
            // Assert
            Assert.AreEqual(file_path1, player.song_map["Godspeed"]);
            Assert.AreEqual(file_path2, player.song_map["A Whisper & A Clamor"]);
        }

        [TestMethod]
        public void Test_Song_Map_Same_Song_Path()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
            player.add_new_song(file_path1);
            player.add_new_song(file_path1);

            // Assert 
            Assert.AreEqual(file_path1, player.song_map["Godspeed"]);
        }


        [TestMethod]
        public void Test_Song_Map_Same_Song_Different_Path()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
            player.add_new_song(file_path1);
            player.add_new_song(file_path_duplicate);

            // Assert
            Assert.AreEqual(file_path_duplicate, player.song_map["Godspeed"]);
            Assert.AreNotEqual(file_path1, player.song_map["Godspeed"]);
        }

        
        [TestMethod]
        public void Test_Album_Map()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
            player.add_new_song(file_path1);
            player.add_new_song(file_path2);

            List<string> songs = player.album_map["Cities"];
            
            // Assert
            Assert.AreEqual(songs[0], file_path1);
            Assert.AreEqual(songs[1], file_path2);
            Assert.IsTrue(songs.Count == 2);
        }
  

        [TestMethod]
        public void Test_Album_Map_Same_Song()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
            player.add_new_song(file_path1);
            player.add_new_song(file_path1);

            List<string> songs = player.album_map["Cities"];
            
            // Assert
            Assert.AreEqual(songs[0], file_path1);
            Assert.IsTrue(songs.Count == 1);
        }


        [TestMethod]
        public void Test_Artist_Map()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
            player.add_new_song(file_path1);
            player.add_new_song(file_path2);
            List<string> songs = player.artist_map["Anberlin"];
  
            // Assert
            Assert.AreEqual(songs[0], file_path1);
            Assert.AreEqual(songs[1], file_path2);
            Assert.IsTrue(songs.Count == 2);
        }


        [TestMethod]
        public void Test_Artist_Map_Same_Song()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
            player.add_new_song(file_path1);
            player.add_new_song(file_path1);
            List<string> songs = player.artist_map["Anberlin"];

            // Assert
            Assert.AreEqual(songs[0], file_path1);
            Assert.IsTrue(songs.Count == 1);
        }


        [TestMethod]
        public void Test_Album_Artwork_Number()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);
            TagLib.File file2 = TagLib.File.Create(file_path2);

            // Act
            player.GetAlbumArtwork_AlbumView(file);
            player.GetAlbumArtwork_AlbumView(file2);

            // Assert
            Assert.IsTrue(player.album_num == 2);
        }


        [TestMethod]
        public void Test_Album_Artwork_Album_Label()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);
            TagLib.File file2 = TagLib.File.Create(file_path2);
            TagLib.File file3 = TagLib.File.Create(file_path3);


            // Act
            player.GetAlbumArtwork_AlbumView(file);
            player.GetAlbumArtwork_AlbumView(file2);
            player.GetAlbumArtwork_AlbumView(file3);

            // Assert
            Assert.AreEqual(player.albumLabel[0].Text, "Cities");
            Assert.AreEqual(player.albumLabel[1].Text, "Cities");
            Assert.AreEqual(player.albumLabel[2].Text, "The Da Vinci Code");
        }


        [TestMethod]
        public void Test_Album_Artwork_Arist_Label()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);
            TagLib.File file2 = TagLib.File.Create(file_path2);
            TagLib.File file3 = TagLib.File.Create(file_path3);


            // Act
            player.GetAlbumArtwork_AlbumView(file);
            player.GetAlbumArtwork_AlbumView(file2);
            player.GetAlbumArtwork_AlbumView(file3);

            // Assert
            Assert.AreEqual(player.albumArtistLabel[0].Text, "Anberlin");
            Assert.AreEqual(player.albumArtistLabel[1].Text, "Anberlin");
            Assert.AreEqual(player.albumArtistLabel[2].Text, "Hans Zimmer");
        }


        [TestMethod]
        public void Test_Increase_Album_Array_PictureBox()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);

            // Act
            for (int i = 0; i < 50; ++i)
                player.GetAlbumArtwork_AlbumView(file);

            player.increase_album_array();

            // Assert
            Assert.IsTrue(player.albums.Length == 100);
            Assert.IsTrue(player.album_size == 100);
            Assert.IsTrue(player.album_num == 50);

            for (int i = 0; i < 5; ++i)
                player.GetAlbumArtwork_AlbumView(file);

            Assert.IsTrue(player.album_num == 55);
        }


        [TestMethod]
        public void Test_Increase_Album_Array_AlbumLabel()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);

            // Act
            for (int i = 0; i < 50; ++i)
                player.GetAlbumArtwork_AlbumView(file);

            player.increase_album_array();

            // Assert
            Assert.IsTrue(player.albumLabel.Length == 100);
            Assert.IsTrue(player.album_size == 100);
            Assert.IsTrue(player.album_num == 50);

            for (int i = 0; i < 5; ++i)
                player.GetAlbumArtwork_AlbumView(file);

            Assert.IsTrue(player.album_num == 55);
        }


        [TestMethod]
        public void Test_Increase_Album_Array_ArtistLabel()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);

            // Act
            for (int i = 0; i < 50; ++i)
                player.GetAlbumArtwork_AlbumView(file);

            player.increase_album_array();

            // Assert
            Assert.IsTrue(player.albumArtistLabel.Length == 100);
            Assert.IsTrue(player.album_size == 100);
            Assert.IsTrue(player.album_num == 50);

            for (int i = 0; i < 5; ++i)
                player.GetAlbumArtwork_AlbumView(file);

            Assert.IsTrue(player.album_num == 55);
        }

        [TestMethod]
        public void Test_Increase_Album_Fail()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();
            TagLib.File file = TagLib.File.Create(file_path1);

            // Act
            for (int i = 0; i < 49; ++i)
                player.GetAlbumArtwork_AlbumView(file);

            player.increase_album_array();

            // Assert
            Assert.IsTrue(player.albumArtistLabel.Length == 50);
            Assert.IsTrue(player.album_size == 50);
            Assert.IsTrue(player.album_num == 49);
        }


        [TestMethod]
        public void Test_Song_Selected()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
            player.play_song(file_path1);

            // Assert
            Assert.IsTrue(player.song_selected);
        }


        [TestMethod]
        public void Test_Song_Selected_Fail()
        {
            // Arrange
            var player = new BearPlayer.Bear_Player();

            // Act
           
            // Assert
            Assert.IsFalse(player.song_selected);
            Assert.IsTrue(!player.song_selected);
        }


    }
}
