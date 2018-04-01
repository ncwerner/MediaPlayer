using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BearPlayer {
    class Song {

        //Properties
        public TagLib.File File { get; }

        public string Path { get; }

        public string Name { get; }

        public string Duration { get; }

        public int Length { get; }

        public string Album { get; }

        public string[] Artists { get; }

        public System.Drawing.Image Artwork { get; }

        //Constructors

        //Takes the absolute path to the song file
        public Song(string path) {
            //Create the Tag
            File = TagLib.File.Create(path);
            Path = path;

            //Set the typical info
            Name = File.Tag.Title;
            Album = File.Tag.Album;
            Artists = File.Tag.Performers;

            //Set the duration & length values
            Length = this.getLength(File.Properties.Duration);
            Duration = this.getDuration(File.Properties.Duration);

            //Get the album artwork
            Artwork = this.getArtwork(new MemoryStream(File.Tag.Pictures[0].Data.Data));
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
