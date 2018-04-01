using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BearPlayer {
    class Song {

        //Song File
        private TagLib.File songFile;
        private string uri;

        //Song information
        private string name;
        private string duration;
        private int length;

        //Album & Artist info
        private string album;
        private string[] artists;
        private System.Drawing.Image artwork;

        //Properties
        public TagLib.File File {
            get { return songFile; }
        }

        public string Path {
            get { return uri; }
        }

        public string Name {
            get { return name; }
        }

        public string Duration {
            get { return duration; }
        }

        public int Length {
            get { return length; }
        }

        public string Album {
            get { return album; }
        }

        public string[] Artists {
            get { return artists; }
        }

        public System.Drawing.Image Artwork {
            get { return artwork; }
        }

        //Constructor
        //Takes the absolute path to the song file
        public Song(string path) {
            //Create the Tag
            songFile = TagLib.File.Create(path);
            uri = path;

            //Set the typical info
            name = songFile.Tag.Title;
            album = songFile.Tag.Album;
            artists = songFile.Tag.Performers;

            //Set the duration & length values
            length = this.getLength(songFile.Properties.Duration);
            duration = this.getDuration(songFile.Properties.Duration);

            //Get the album artwork
            artwork = this.getArtwork(new MemoryStream(songFile.Tag.Pictures[0].Data.Data));
        }

        //Internal Methods
        private int getLength(TimeSpan songLen) {
            return (songLen.Minutes * 60) + songLen.Seconds;
        }

        private string getDuration(TimeSpan songLen) {

            string sec = (songLen.Seconds < 10) ? ":0" + songLen.Seconds.ToString() : ":" + songLen.Seconds.ToString();

            return songLen.Minutes.ToString() + sec;
        }

        private System.Drawing.Image getArtwork(MemoryStream pic) {
            return System.Drawing.Image.FromStream(pic);
        }
    }
}
