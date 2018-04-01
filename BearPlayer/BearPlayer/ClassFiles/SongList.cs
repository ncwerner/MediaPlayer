using System.IO;
using System.Collections.Generic;

using Newtonsoft.Json;
using System.Collections;

namespace BearPlayer {
    class SongPath {
        public string songName { get; set; }
        public string songPath { get; set; }

        public SongPath() {}
        public SongPath(string name, string path) {
            songName = name;
            songPath = path;
        }
    }

    internal class SongList : IEnumerable {
        private static string songFilePath = "songs.json";
        private Dictionary<string, Song> songList;

        public SongList() {
            songList = new Dictionary<string, Song>();
        }

        public void readAllSongs() {
            songList.Clear();

            string songPathsStr = File.ReadAllText(songFilePath);
            var songPaths = JsonConvert.DeserializeObject<List<SongPath>>(songPathsStr);

            foreach (SongPath path in songPaths) {
                var song = new Song(path.songPath);
                songList.Add(path.songName, song);
            }
        }

        public void writeAllSongs() {
            var songPaths = new List<SongPath>();
            foreach (Song song in songList.Values) {
                songPaths.Add(new SongPath(song.Name, song.Path));
            }

            var songPathJson = JsonConvert.SerializeObject(songPaths);
            File.WriteAllText(songFilePath, songPathJson);
        }

        public bool contains(string songName) {
            return songList.ContainsKey(songName);
        }

        public bool contains(Song song) {
            return songList.ContainsKey(song.Name);
        }

        public void add(Song song) {
            songList.Add(song.Name, song);
        }

        public void remove(string songName) {
            songList.Remove(songName);
        }

        public void remove(Song song) {
            songList.Remove(song.Name);
        }

        public Song get(string songName) {
            return songList[songName];
        }

        IEnumerator IEnumerable.GetEnumerator() {
            foreach(var songPair in songList) {
                yield return songPair.Value;
            }
        }
    }
}
