using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BearPlayer {
    public partial class Bear_Player : Form {
        Timer song_time;

        private BearController controller = new BearController();

        //Song information
        SongList songList;

        //Key:Artist Name Value: List of Songs
        Dictionary<string, List<Song>> artist_map = new Dictionary<string, List<Song>>();

        //Key:Album Name Value: List of Songs
        Dictionary<string, List<Song>> album_map = new Dictionary<string, List<Song>>();

        Dequeue queue = new Dequeue();
        Stack<string> prev_songs = new Stack<string>();

        //Current variables
        view curr_view;
       
        ListView curr_list_box;

        int blink_count;

        private enum view { Albums, Artists, Songs, Playlists, Queue, Artist_Song, Album_Song };
       


        public Bear_Player() {
           
            songList = new SongList();
            songList.readAllSongs();

            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;   // Opens application maximized
            InitializeComponent();

            //timer that will update the scrub bar when the location in the song changes
            song_time = new Timer();
            song_time.Interval = 10;

            //causes the event to go whenever the timer elapses
            song_time.Tick += new EventHandler(song_time_Elapsed);
            
            //Setup the current view
            Artist_View.Visible = false;
            Albums_View.Visible = false;
            Songs_View.Visible = true;
            Playlists_View.Visible = false;
            Artist_Song_View.Visible = false;
            Queue_View.Visible = false;
            curr_view = view.Songs;
            curr_list_box = Song_List;

            //Bear blinking magic
            blink_count = 0;
        }

        private void BearPlayer_Load(object sender, EventArgs e) {

        }

        //Pause/play button on click
        public void pictureBox1_Click(object sender, EventArgs e) {
            bool ret = controller.PlayPause();

            //True = Display the pause button, False = display the play button
            if (ret)
                this.playBar.Image = Image.FromFile(@"C:\BearPlayer\Resources\pauseButton.png");
            else
                this.playBar.Image = Image.FromFile(@"C:\BearPlayer\Resources\playButton1.png");
        }


        //method sets cure song to next in queue, pushes old curt song to stack
        public void play_next_song() {
            if (repeat_type == Repeat_Type.Repeat_One) {
                if (curr_song != null || queue.Count() != 0) {
                    if (curr_song == null) {
                        curr_song = queue.Pop_Front();
                    }
                    prev_songs.Clear();
                    queue.Clear();
                    queue.Push_Front(curr_song);
                    play_song(songList.get(curr_song));
                    currentAlbumDisplay();
                    return;
                }
            }
            if (repeat_type == Repeat_Type.Repeat_All) {
                if (queue.Count() == 0 && curr_song != null) {
                    queue.Push_Front(curr_song);
                }
            }

            if (queue.Count() > 0) {
                string removed = queue.Pop_Front();
                play_song(songList.get(removed));

                if (curr_song != null) {
                    if (repeat_type == Repeat_Type.Repeat_All) {
                        queue.Push_Back(curr_song);
                    }
                    else {
                        prev_songs.Push(curr_song);
                    }
                }

                curr_song = removed;
                currentAlbumDisplay();
                //sets the URL for the player as the file path

                //plays the file that is currently set as the URL
            }


        }

        //return false if only resuming takes a URL
        private bool play_song(Song song) {
            bool new_song = false;
            song_selected = true;
            if (controller.PlayerURL != song.Path) {
                controller.PlayerURL = song.Path;
                new_song = true;
            }
            else {
                controller.PlayerPosition = 0;
                new_song = false;
            }
            controller.playerPlay();


            this.playBar.Image = Image.FromFile(@"C:\BearPlayer\Resources\pauseButton.png");
            play = false;
            
            //Gets the duration for the scrub bar
            Song_length_label.Text = song.Duration;

            scrubBar.Maximum = song.Length;
            Current_position_label.Text = "0:00";
            scrubBar.Value = 0;
            //sets the starting position to the current label and the scrub bar
            song_time.Start();

            return new_song;
        }


        //pushes cure song to the front of queue, make curr song the pop of the stack 
        private void play_prev_song() {
            if (repeat_type == Repeat_Type.Repeat_One) {
                if (curr_song != null) {
                    play_song(songList.get(curr_song));
                }
            }
            if (repeat_type == Repeat_Type.Repeat_All) {
                if (queue.Count() != 0) {
                    prev_songs.Push(queue.Pop_Back());
                }
            }
            if (prev_songs.Count != 0) {
                //prevCurrentAlbumDisplay();
                string removed = prev_songs.Pop();
                play_song(songList.get(removed));

                queue.Push_Front(curr_song);
                curr_song = removed;
                currentAlbumDisplay();
                //sets the URL for the player as the file path
                //plays the file that is currently set as the URL
            }
        }


        //imports all songs in folder and updates the screen
        public void importToolStripMenuItem_Click(object sender, EventArgs e) {
            string folder_path = "";
            //initializes the folder path
            using (var folderDialog = new FolderBrowserDialog()) {
                if (folderDialog.ShowDialog() == DialogResult.OK) {
                    folder_path = folderDialog.SelectedPath;
                    //saves the selected folder as folder path
                    getSongs(folder_path);
                    getAlbums(folder_path);
                }
            }
        }

        public void getAlbums(string folder_path) {
            string[] albums = Directory.GetDirectories(@folder_path);
            foreach (string s in albums) {
                getSongs(s);
                getAlbums(s);
            }
        }

        public void getSongs(string folder_path) {
            string[] songs = Directory.GetFiles(@folder_path, "*.mp3");
            foreach (string s in songs) {
                TagLib.File file = TagLib.File.Create(s);

                add_new_song(s);
            }
            update_list_disp();
        }


        //adds a song too the maps 
        private void add_new_song(string path) {
            TagLib.File file = TagLib.File.Create(path);
            var song = new Song(path);

            if (songList.contains(song)) {
                songList.remove(song);
            }

            songList.add(song);

            // if album not in map, make that key and assign it to a new list containing added song
            if (!album_map.ContainsKey(song.Album)) {
                var songsInAlbum = new List<Song>();
                songsInAlbum.Add(new Song(path));

                album_map.Add(song.Album, songsInAlbum);
            }
            else {
                album_map[file.Tag.Album].Add(song);   //if album already in map, add song to the assigned list
            }

            foreach (string art in file.Tag.Performers) {
                if (!artist_map.ContainsKey(art)) {
                    var songsByArtist = new List<Song>();
                    songsByArtist.Add(new Song(path));
                    artist_map.Add(art, songsByArtist);
                }
                else {
                    artist_map[art].Add(song);
                }
            }
        }


        //imports single song and updates display
        private void importSongToolStripMenuItem_Click(object sender, EventArgs e) {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //creates a new file dialog each time the inport song button is clicked
            openFileDialog1.Filter = "Music Files| *.mp3";
            //sets the filter to only show mp3 files
            openFileDialog1.Title = "Select a Song";
            string file_path = "";
            //initializes the file path
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                file_path = openFileDialog1.FileName;
                //get song name from file
                add_new_song(file_path);
                //set the path that is saved to be the text for the textbox in the gui
                update_list_disp();
            }

        }

        //displays album during playback
        private void currentAlbumDisplay() {

            //Get the current song from the map
            Song song = songList.get(curr_song);
         
            pictureBox1.Image = song.Artwork;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            artistLabel.Text = song.Artists[0];
            titleLabel.Text = song.Name;
            curAlbumLabel.Text = song.Album;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void volumeUpToolStripMenuItem_Click(object sender, EventArgs e) {
            if (controller.PlayerVolume < 90) {
                //if the volume can be increased by 10 then it adds ten to volume
                controller.PlayerVolume = controller.PlayerVolume + 10;
            }
            else {
                //if volume is greater than 90 already sets the volume to 100
                controller.PlayerVolume = 100;
            }
            volumeSlider.Value = controller.PlayerVolume;
        }


        private void volumeDownToolStripMenuItem_Click(object sender, EventArgs e) {
            if (controller.PlayerVolume > 10) {
                //if the volume can be decreased by 10 then it subtracts ten from the volume
                controller.PlayerVolume = controller.PlayerVolume - 10;
            }
            else {
                //if volume is less than 10 already sets the volume to 0
                controller.PlayerVolume = 0;
            }
            volumeSlider.Value = controller.PlayerVolume;
        }


        private void volumeSlider_Scroll_1(object sender, EventArgs e) {
            controller.PlayerVolume = volumeSlider.Value;
            //path.Text = (volumeSlider.Value).ToString();
        }

        private void next_button_Click(object sender, EventArgs e) {
            
            play_next_song();
            update_list_disp();
        }


        private void previous_button_Click(object sender, EventArgs e) {
            if (scrubBar.Value <= 5) {
                play_prev_song();
                update_list_disp();
            }
            else {
                play_song(songList.get(curr_song));
            }

        }

        private void scrubBar_Scroll(object sender, EventArgs e) {

            controller.playerPause();
            controller.PlayerPosition = scrubBar.Value;

            controller.playerPlay();
            //add clicking onto the slide bar to change to the location
            //maybe add functionality to change to parts of the song using number keys

        }

        private void song_time_Elapsed(object sender, EventArgs e) {
            scrubBar.Value = (int)controller.PlayerPosition;
            //makes the scrub bar follow the song as it plays
            if (scrubBar.Value % 60 >= 10) {
                Current_position_label.Text = (scrubBar.Value / 60).ToString() + ":" + (scrubBar.Value % 60).ToString();
            }
            else {
                Current_position_label.Text = (scrubBar.Value / 60).ToString() + ":0" + (scrubBar.Value % 60).ToString();
            }
            if (scrubBar.Value >= scrubBar.Maximum) {
                play_next_song();
                update_list_disp();
            }
            if (scrubBar.Value % 8 == 5) {
                if (blink_count < 20) {
                    this.bear_logo.Image = Image.FromFile(@"C:\BearPlayer\Resources\bear_blink.png");
                    blink_count++;
                }
            }
            else {
                blink_count = 0;
            }
            if (blink_count == 20) {
                this.bear_logo.Image = Image.FromFile(@"C:\BearPlayer\Resources\bear.png");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            if (e.Node.Text.Equals("Artists")) {
                Artist_View.Visible = true;
                Albums_View.Visible = false;
                Album_Song_View.Visible = false;
                Songs_View.Visible = false;
                Playlists_View.Visible = false;
                Artist_Song_View.Visible = false;
                Queue_View.Visible = false;
                curr_view = view.Artists;
                curr_list_box = Artist_List;   // Change to artist list box
            }

            else if (e.Node.Text.Equals("Albums")) {
                Artist_View.Visible = false;
                Albums_View.Visible = true;
                Album_Song_View.Visible = false;
                Songs_View.Visible = false;
                Playlists_View.Visible = false;
                Artist_Song_View.Visible = false;
                Queue_View.Visible = false;
                curr_view = view.Albums;
                curr_list_box = Album_List;  // Change to album list box
            }

            else if (e.Node.Text.Equals("Songs")) {
                Artist_View.Visible = false;
                Albums_View.Visible = false;
                Album_Song_View.Visible = false;
                Songs_View.Visible = true;
                Playlists_View.Visible = false;
                Artist_Song_View.Visible = false;
                Queue_View.Visible = false;
                curr_view = view.Songs;
                curr_list_box = Song_List;   // Change to song list box
            }

            else if (e.Node.Text.Equals("Playlists")) {
                Artist_View.Visible = false;
                Albums_View.Visible = false;
                Album_Song_View.Visible = false;
                Songs_View.Visible = false;
                Playlists_View.Visible = true;
                Artist_Song_View.Visible = false;
                Queue_View.Visible = false;
                curr_view = view.Playlists;
            }
            else if (e.Node.Text.Equals("Queue")) {
                Artist_View.Visible = false;
                Albums_View.Visible = false;
                Songs_View.Visible = false;
                Playlists_View.Visible = false;
                Artist_Song_View.Visible = false;
                Album_Song_View.Visible = false;
                Queue_View.Visible = true;
                curr_view = view.Queue;
                curr_list_box = Queue_List;   // Change to queue list box
            }

            update_list_disp();
        }

        //updates whatever list box is currently being viewed with the current map information 
        private void update_list_disp() {
            curr_list_box.Items.Clear();

            // Artist Display 
            if (curr_view == view.Artists) {
                foreach (string s in artist_map.Keys) {
                    curr_list_box.Items.Add(s);
                }
            }

            // Album Display
            else if (curr_view == view.Albums) {
                int album_count = 0;
                foreach (string s in album_map.Keys) {
                    Song song = album_map[s][0];

                    Album_List.View = View.LargeIcon;
                    Album_List.LargeImageList = Artwork_List;

                    Album_List.Items.Add(new ListViewItem { ImageIndex = album_count, Text = song.Album + "\n" + song.Artists[0] });
                    ++album_count;
                }
            }

            // Song Display
            else if (curr_view == view.Songs) {
                foreach (Song song in songList) {
                    curr_list_box.Items.Add(List_Column_Info(song));   // Fill row with song tag information
                }
            }

            // Queue Display
            else if (curr_view == view.Queue) {
                int size = queue.Count();
                // Parse through every element in the queue
                for (int i = 0; i < size; ++i) {
                    string dequeue = queue.ElementAt(i);   // Retrieve each element in queue
                    Song song = songList.get(dequeue);   // Map song in queue to file address
                    curr_list_box.Items.Add(List_Column_Info(song));    // Fill row with song tag information
                }
            }
            // Artist Song Display
            else if (curr_view == view.Artist_Song) {
                List<Song> artistSongs = artist_map[selected_artist];
                foreach (Song song in artistSongs) {
                    curr_list_box.Items.Add(List_Column_Info(song));   // Fill row with song tag information   
                }
            }
            // Album Song Display
            else if (curr_view == view.Album_Song) {
                List<Song> albumSongs = album_map[selected_album];
                foreach (Song song in albumSongs) {
                    curr_list_box.Items.Add(List_Column_Info(song));   // Fill row with song tag information   
                }
            }
        }


        // Method to retrieve the title, album, artist, and duration information from a song, and add it to a list row
        private ListViewItem List_Column_Info(Song song) {
            // Create new entry into list table
            ListViewItem item = new ListViewItem();
            item.Text = song.Name;   // Add title 
            item.SubItems.Add(song.Album);   // Add album
            item.SubItems.Add(song.Artists[0]);   // Add artist

            item.SubItems.Add(song.Duration);   // Add time

            return item;
        }





        // Method for list view on menu bar
        private void listViewToolStripMenuItem_Click(object sender, EventArgs e) {
            Artist_View.Visible = false;
            Albums_View.Visible = false;
            Songs_View.Visible = true;
            Playlists_View.Visible = false;
            Queue_View.Visible = false;
            Artist_Song_View.Visible = false;
            Album_Song_View.Visible = false;
            curr_view = view.Songs;
        }

        private void Artist_List_SelectedIndexChanged(object sender, EventArgs e) {
            Artist_View.Visible = false;
            Albums_View.Visible = false;
            Songs_View.Visible = false;
            Playlists_View.Visible = false;
            Queue_View.Visible = false;
            Artist_Song_View.Visible = true;
            Album_Song_View.Visible = false;


            selected_artist = curr_list_box.SelectedItems[0].Text;
            curr_view = view.Artist_Song;
            curr_list_box = Artist_Song_List;
            treeView1.SelectedNode = null;
            update_list_disp();
        }

        private void Album_List_SelectedIndexChanged(object sender, EventArgs e) {
            Artist_View.Visible = false;
            Albums_View.Visible = false;
            Songs_View.Visible = false;
            Playlists_View.Visible = false;
            Queue_View.Visible = false;
            Artist_Song_View.Visible = false;
            Album_Song_View.Visible = true;

            selected_album = curr_list_box.SelectedItems[0].Text.Split('\n')[0];
            curr_view = view.Album_Song;
            curr_list_box = Album_Song_List;
            treeView1.SelectedNode = null;
            update_list_disp();
        }

        // Method for album view on menu bar
        private void albumViewToolStripMenuItem_Click(object sender, EventArgs e) {
            Artist_View.Visible = false;
            Albums_View.Visible = true;
            Songs_View.Visible = false;
            Playlists_View.Visible = false;
            Queue_View.Visible = false;
            Artist_Song_View.Visible = false;
            Album_Song_View.Visible = false;
            curr_view = view.Albums;
        }

        private void Artist_Song_List_SelectedIndexChanged(object sender, EventArgs e) {
            list_item_selected();
        }

        private void Album_Song_List_SelectedIndexChanged(object sender, EventArgs e) {
            list_item_selected();
        }

        private void Song_List_SelectedIndexChanged(object sender, EventArgs e) {
            list_item_selected();
        }

        private void Queue_List_SelectedIndexChanged(object sender, EventArgs e) {
            list_item_selected();
        }

        private void list_item_selected() {
            if (curr_list_box.SelectedIndices.Count <= 0) return;
            int i = curr_list_box.SelectedIndices[0];
            if (i >= 0 && i < curr_list_box.Items.Count) {
                if (shuffle) {
                    fill_shuffled_queue(curr_list_box.Items[i].Text.ToString());
                }
                else {
                    fill_unshuffled_queue(curr_list_box.Items[i].Text.ToString());
                }
                play_next_song();
            }
        }

        private void fill_shuffled_queue(string start_name) {
            queue.Clear();
            prev_songs.Clear();
            curr_song = null;
            bool found = false;

            queue.Push_Back(start_name);

            List<string> songs_arr = new List<string>();
            for (int i = 0; i < curr_list_box.Items.Count; ++i) {
                if (!curr_list_box.Items[i].Text.ToString().Equals(start_name)) {
                    songs_arr.Add(curr_list_box.Items[i].Text.ToString());
                }
            }

            for (int i = songs_arr.Count - 1; i > 0; i--) {
                Random ran = new Random();
                int j = ran.Next() % (i + 1);
                string temp = songs_arr[i];
                songs_arr[i] = songs_arr[j];
                songs_arr[j] = temp;
            }

            foreach (string s in songs_arr) {
                queue.Push_Back(s);
            }
        }

        //fills queue with selected song and all following songs,takes a song name
        private void fill_unshuffled_queue(string start_name) {
            queue.Clear();
            prev_songs.Clear();
            curr_song = null;
            bool found = false;
            Dequeue temp_deq = new Dequeue();

            for (int i = 0; i < curr_list_box.Items.Count; ++i) {
                string s = curr_list_box.Items[i].Text.ToString();
                if (s.Equals(start_name)) {
                    found = true;
                    queue.Push_Back(s);
                }
                else if (found) {
                    queue.Push_Back(s);
                }
                else {
                    temp_deq.Push_Front(s);
                }
            }
            if (repeat_type == Repeat_Type.Repeat_All) {
                int c = temp_deq.Count();
                for (int i = 0; i < c; i++) {
                    queue.Push_Back(temp_deq.Pop_Back());
                }
            }
            else {
                int c = temp_deq.Count();
                for (int i = 0; i < c; i++) {
                    prev_songs.Push(temp_deq.Pop_Back());
                }

            }
        }

        private void shuffle_toggle_Click(object sender, EventArgs e) {
            shuffle = !shuffle;
            if (shuffle) shuffle_toggle.Image = Image.FromFile(@"C:\BearPlayer\Resources\shuffleButtonOn.png");
            else shuffle_toggle.Image = Image.FromFile(@"C:\BearPlayer\Resources\shuffleButtonOff.png");
        }

        private void repeat_button_Click(object sender, EventArgs e) {
            if (repeat_type == Repeat_Type.Off) {
                repeat_type = Repeat_Type.Repeat_All;
                repeat_button.Image = Image.FromFile(@"C:\BearPlayer\Resources\Repeat_All.png");

                Dequeue temp = new Dequeue();
                int c = prev_songs.Count();
                for (int i = 0; i < c; i++) {
                    temp.Push_Back(prev_songs.Pop());
                }
                for (int i = 0; i < c; i++) {
                    queue.Push_Back(temp.Pop_Back());
                }
                if (c == 0 && queue.Count() == 0) {
                    queue.Push_Back(curr_song);
                }
            }
            else if (repeat_type == Repeat_Type.Repeat_All) {
                repeat_type = Repeat_Type.Repeat_One;
                repeat_button.Image = Image.FromFile(@"C:\BearPlayer\Resources\Repeat_One.png");

                if (curr_song != null) {
                    prev_songs.Clear();
                    queue.Clear();
                    queue.Push_Front(curr_song);
                }
            }
            else {
                repeat_type = Repeat_Type.Off;
                repeat_button.Image = Image.FromFile(@"C:\BearPlayer\Resources\Repeat.png");
            }
            update_list_disp();
        }



        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e) {
            if ((e.State & TreeNodeStates.Hot) != 0) {

                using (Brush b = new SolidBrush(Color.FromArgb(unchecked((int)0xFFB3D7F3))))
                    e.Graphics.FillRectangle(b, e.Bounds);
                using (Pen p = new Pen(new SolidBrush(Color.FromArgb(unchecked((int)0xFF0078D7))))) {
                    Rectangle border_bounds = e.Bounds;
                    border_bounds.Width -= 1;
                    border_bounds.Height -= 1;
                    e.Graphics.DrawRectangle(p, border_bounds);
                }
                e.Graphics.DrawString(e.Node.Text, e.Node.NodeFont, Brushes.Black, e.Bounds);
            }
            else {
                e.DrawDefault = true;
            }
        }
    }
}
