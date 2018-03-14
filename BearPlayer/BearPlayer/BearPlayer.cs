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


namespace BearPlayer
{
    public partial class Bear_Player : Form
    {
        public bool play;   // Global variable for controling play/pause state
        //string file_path;   // directory of chosed song
        //string song_name; //song name pulled from imported file
        WMPLib.WindowsMediaPlayer Player;   //player object from WMP library
        //string[] songs = new String[0];
       // List<string> disp_song_paths = new List<string>();
        //int playing_index = 0;
        Timer song_time;
        PictureBox[] albums = new PictureBox[50];
        int album_num;
        int album_x = 190;
        int album_y = 100;
        Dictionary<string, string> song_map = new Dictionary<string,string>();
        Dictionary<string, List<string> > artist_map = new Dictionary<string, List<string>>();
        Dictionary<string, List<string> > album_map = new Dictionary<string, List<string>>();
        view curr_view;
        Queue<string> queue = new Queue<string>();
        Stack<string> prev_songs = new Stack<string>();
        string curr_song;
        ListView curr_list_box;

        public Bear_Player()
        {
            play = true;   // Begin program with play button

            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;   // Opens application maximized
            InitializeComponent();
            Player = new WMPLib.WindowsMediaPlayer();
            Player.settings.volume = 25;
            song_time = new Timer();
            //timer that will update the scrub bar when the location in the song changes
            song_time.Interval = 100;
            song_time.Tick += new EventHandler(song_time_Elapsed);
            //causes the event to go whenever the timer elapses

            curr_list_box = Song_List;
            curr_view = view.Artists;
            curr_song = null;
        }

        private void BearPlayer_Load(object sender, EventArgs e)
        {
   
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (curr_list_box.Items.Count <= 0) return;
            if (play)
            {
                //curr_list_box.SelectedIndex = playing_index;
                //string curr_song = curr_list_box.Items[playing_index].ToString();
                if(Player.URL == null)
                {
                    play = false;
                }
                else
                {
                    this.playBar.Image = Image.FromFile(@"C:\BearPlayer\Resources\pauseButton.png");
                    Player.controls.play();
                }
                
            }
            else
            {
                this.playBar.Image = Image.FromFile(@"C:\BearPlayer\Resources\playButton1.png");
                Player.controls.pause(); // SHOULD BE CHANGED TO PAUSE EVENTUALLY BUT CURRENTLY PAUSE CAUSES IT TO REPEAT IMMEDIATELY
            }
            play = !play;
        }

        public void play_next_song()
        {
            
            if(queue.Count > 0)
            {
                string removed = queue.Dequeue();
                play_song( song_map[removed] );

                if(curr_song != null)
                {
                    prev_songs.Push(curr_song);
                }

                curr_song = removed;
                
                //sets the URL for the player as the file path
                
                //plays the file that is currently set as the URL
            }

        }

        //return false if only resuming
        private bool play_song(string url)
        {
            bool new_song = false;
            if (Player.URL != url)
            {
                Player.URL = url;
                new_song = true;
            }
            else
            {
                new_song = false;
            }
            Player.controls.play();
            this.playBar.Image = Image.FromFile(@"C:\BearPlayer\Resources\pauseButton.png");
            play = false;
            TagLib.File song_file = TagLib.File.Create(url);
            //creates a file to get the duration for the scrub bar
            if (song_file.Properties.Duration.Seconds >= 10)
                //checks the amount of digits in seconds
            {
                Song_length_label.Text = song_file.Properties.Duration.Minutes.ToString() + ":" + song_file.Properties.Duration.Seconds.ToString();
            }
            else
            {
                Song_length_label.Text = song_file.Properties.Duration.Minutes.ToString() + ":0" + song_file.Properties.Duration.Seconds.ToString();
            }
            scrubBar.Maximum = song_file.Properties.Duration.Seconds + (song_file.Properties.Duration.Minutes * 60);
            Current_position_label.Text = "0:00";
            scrubBar.Value = 0;
            //sets the starting position to the current label and the scrub bar
            song_time.Start();

            return new_song;
        }

        private void play_prev_song()
        {
            if(prev_songs.Count != 0)
            {
                string removed = prev_songs.Pop();
                play_song(song_map[removed]);

                queue.Enqueue(curr_song);                                                           //////////////////////////to be changed when dequeue made
                curr_song = removed;
                //sets the URL for the player as the file path
                //plays the file that is currently set as the URL
            }
        }

        public void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folder_path = "";
            //initializes the folder path
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    folder_path = folderDialog.SelectedPath;
                    //saves the selected folder as folder path
                    string[] songs = Directory.GetFiles(@folder_path, "*.mp3");
                    foreach (string s in songs)
                    {
                        TagLib.File file = TagLib.File.Create(s);

                        add_new_song(s);

                    }
                    update_list_disp();
                }
            }
            
        }
        
        private void add_new_song(string path)
        {
            TagLib.File file = TagLib.File.Create(path);

            if (!song_map.ContainsKey(file.Tag.Title))
            {
                song_map.Add(file.Tag.Title, path);
            }
            else
            {
                song_map[file.Tag.Title] = path;
            }

            if (!album_map.ContainsKey(file.Tag.Album))
            {
                List<string> new_list = new List<string>();
                new_list.Add(path);
                album_map.Add(file.Tag.Album, new_list);
            }
            else
            {
                album_map[file.Tag.Album].Add(path);
            }
            foreach (string art in file.Tag.Performers)
            {
                if (!artist_map.ContainsKey(art))
                {
                    List<string> new_list = new List<string>();
                    new_list.Add(path);
                    artist_map.Add(art, new_list);
                }
                else
                {
                    artist_map[art].Add(path);
                }
            }
        }

        private void importSongToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //creates a new file dialog each time the inport song button is clicked
            openFileDialog1.Filter = "Music Files| *.mp3";
            //sets the filter to only show mp3 files
            openFileDialog1.Title = "Select a Song";
            string file_path = "";
            //initializes the file path
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                //get song name from file
                add_new_song(file_path);
                //set the path that is saved to be the text for the textbox in the gui
                update_list_disp();
            }

        }
        
        //method that gets album artwork of file
        private void getAlbumArtwork(TagLib.File file)
        {
            album_num++;
            MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data);
            System.Drawing.Image artwork = System.Drawing.Image.FromStream(ms);
            albums[album_num] = new PictureBox
            {
                Visible = true,
                Location = new Point(album_x, album_y),
                Size = new Size(250,250),
                Image = artwork,
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            this.Controls.Add(albums[album_num]);
            album_x = album_x + 350;
            if(album_num % 4 == 0)
            {
                album_x = 190;
                album_y = album_y + 350;
            }
        }

        //gets song name of file
        private string getSongName(TagLib.File file)
        {
            return file.Tag.Title;
        }

        //gets the album name
        private string getAlbumName(TagLib.File file)
        {
            return file.Tag.Album;
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void volumeUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Player.settings.volume < 90)
            {
                //if the volume can be increased by 10 then it adds ten to volume
                Player.settings.volume = Player.settings.volume + 10;
            }
            else
            {
                //if volume is greater than 90 already sets the volume to 100
                Player.settings.volume = 100;
            }
            volumeSlider.Value = Player.settings.volume;
        }


        private void volumeDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Player.settings.volume > 10)
            {
                //if the volume can be decreased by 10 then it subtracts ten from the volume
                Player.settings.volume = Player.settings.volume - 10;
            }
            else
            {
                //if volume is less than 10 already sets the volume to 0
                Player.settings.volume = 0;
            }
            volumeSlider.Value = Player.settings.volume;
        }


        private void volumeSlider_Scroll_1(object sender, EventArgs e)
        {
            Player.settings.volume = volumeSlider.Value;
            //path.Text = (volumeSlider.Value).ToString();
        }

        private void fill_unshuffled_queue(string start_name)
        {
            queue.Clear();
            bool found = false;

            for(int i = 0; i < curr_list_box.Items.Count; ++i)
            {
                string s = curr_list_box.Items[i].Text.ToString();
                if (found)
                {
                    queue.Enqueue(s);
                }
                if (s.Equals(start_name))
                {
                    found = true;
                    queue.Enqueue(s);
                }
            }
        }


        private void next_button_Click(object sender, EventArgs e)
        {
            /*if( playing_index < disp_song_paths.Count() - 1)
            {
                playing_index++;
                play_new_song(disp_song_paths[playing_index]);
                curr_list_box.SelectedIndex = playing_index;
            }*/
            play_next_song();
        }


        private void previous_button_Click(object sender, EventArgs e)
        {
            /*f (playing_index > 0)
             {
                 playing_index--;
                 play_new_song(disp_song_paths[playing_index]);
                 curr_list_box.SelectedIndex = playing_index;
             }*/
            play_prev_song();
        }

        private void scrubBar_Scroll(object sender, EventArgs e)
        {
            //path.Text = Player.controls.currentPosition.ToString();
            //path.Text = scrubBar.Value.ToString();
            Player.controls.pause();
            Player.controls.currentPosition = scrubBar.Value;
            Player.controls.play();
            //add clicking onto the slide bar to change to the location
            //maybe add functionality to change to parts of the song using number keys

        }

        private void song_time_Elapsed(object sender, EventArgs e)
        {
            scrubBar.Value = (int)Player.controls.currentPosition;
            //makes the scrub bar follow the song as it plays
            if (scrubBar.Value % 60 >= 10)
            {
                Current_position_label.Text = (scrubBar.Value / 60).ToString() + ":" + (scrubBar.Value % 60).ToString();
            }
            else
            {
                Current_position_label.Text = (scrubBar.Value / 60).ToString() + ":0" + (scrubBar.Value % 60).ToString();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text.Equals("Artists"))
            {
                Artists_View.Visible = true;
                Albums_View.Visible = false;
                Songs_View.Visible = false;
                Playlists_View.Visible = false;
                curr_view = view.Artists;
            }

            else if (e.Node.Text.Equals("Albums"))
            {
                Artists_View.Visible = false;
                Albums_View.Visible = true;
                Songs_View.Visible = false;
                Playlists_View.Visible = false;
                curr_view = view.Albums;
            }

            else if (e.Node.Text.Equals("Songs"))
            {
                Artists_View.Visible = false;
                Albums_View.Visible = false;
                Songs_View.Visible = true;
                Playlists_View.Visible = false;
                curr_view = view.Songs;
            }

            else if (e.Node.Text.Equals("Playlists"))
            {
                Artists_View.Visible = false;
                Albums_View.Visible = false;
                Songs_View.Visible = false;
                Playlists_View.Visible = true;
                curr_view = view.Playlists;
            }
            update_list_disp();
        }


        private void update_list_disp()
        {
            curr_list_box.Items.Clear();
            if (curr_view == view.Artists)
            {
                foreach (string s in artist_map.Keys)
                {
                    curr_list_box.Items.Add(s);
                }
            }
            else if (curr_view == view.Albums)
            {
                foreach (string s in album_map.Keys)
                {
                    curr_list_box.Items.Add(s);
                }
            }
            else if (curr_view == view.Songs)
            {
                foreach (string s in song_map.Keys)
                {
                    TagLib.File file = TagLib.File.Create(song_map[s]);
           
                    // Create new entry into list table
                    ListViewItem item = new ListViewItem();
                    item.Text = file.Tag.Title;   // Add title 
                    item.SubItems.Add(file.Tag.Album);   // Add album
                    item.SubItems.Add(file.Tag.FirstAlbumArtist);   // Add artist

                    // Parse minutes and seconds together for duration
                    string duration = file.Properties.Duration.Minutes.ToString();
                    string seconds = ":" + file.Properties.Duration.Seconds.ToString();

                    // If seconds is less than 10, add an additional 0 in front
                    if (file.Properties.Duration.Seconds < 10)
                        seconds = ":0" + file.Properties.Duration.Seconds.ToString();

                    duration = duration + seconds;
                    item.SubItems.Add(duration);   // Add time

                    curr_list_box.Items.Add(item);   // Push new entry into list table

                    //(!play && playing_index < disp_song_paths.Count() ) curr_list_box.SelectedIndex = playing_index;
                }
            }
            else
            {

            }
            
        }
        private enum view { Albums, Artists, Songs, Playlists };

        private void Song_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = curr_list_box.SelectedIndices[0];
            if (i >= 0 && i < curr_list_box.Items.Count)
            {
                fill_unshuffled_queue(curr_list_box.Items[i].ToString());
                play_next_song();
                //playing_index = i;
            }
        }
    }
}
