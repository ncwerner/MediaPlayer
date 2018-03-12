﻿using System;
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
    public partial class BearPlayer : Form
    {
        public bool play;   // Global variable for controling play/pause state
        string file_path;   // directory of chosed song
        string song_name; //song name pulled from imported file
        WMPLib.WindowsMediaPlayer Player;   //player object from WMP library
        string[] songs = new String[0];
        int playing_index = 0;

        public BearPlayer()
        {
            play = true;   // Begin program with play button

            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;   // Opens application maximized
            InitializeComponent();
            Player = new WMPLib.WindowsMediaPlayer();
        }

        private void BearPlayer_Load(object sender, EventArgs e)
        {
   
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            if (songs.Length <= 0) return;
            if (play)
            {
                play_new_song(songs[playing_index]);
            }
            else
            {
                this.playBar.Image = Image.FromFile(@"C:\BearPlayer\Resources\playButton1.png");
                Player.controls.pause(); // SHOULD BE CHANGED TO PAUSE EVENTUALLY BUT CURRENTLY PAUSE CAUSES IT TO REPEAT IMMEDIATELY
            }
            play = !play;
        }
        public void play_new_song(string url)
        {
            if (songs.Length <= 0) return;

            this.playBar.Image = Image.FromFile(@"C:\BearPlayer\Resources\pauseButton.png");
            if (Player.URL != url)
            {
                Player.URL = url;
            }
            //sets the URL for the player as the file path
            Player.controls.play();
            //plays the file that is currently set as the URL
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
                }
            }
            path.Text = folder_path;
            songs = Directory.GetFiles(@folder_path, "*.mp3");
            path.Text = "Songs: " + songs.Length;
            if( songs.Length > 0)
            {
                file_path = songs[0];
            }
            foreach (string s in songs)
            {
                TagLib.File file = TagLib.File.Create(s);
                listBox1.Items.Add(file.Tag.Title);
            }
            playing_index = 0;
            //shows the path in the text box
        }

        private void importSongToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //creates a new file dialog each time the inport song button is clicked
            openFileDialog1.Filter = "Music Files| *.mp3";
            //sets the filter to only show mp3 files
            openFileDialog1.Title = "Select a Song";
            file_path = "";
            //initializes the file path
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                file_path = openFileDialog1.FileName;
            }
            path.Text = file_path;
            //get song name from file
            TagLib.File file = TagLib.File.Create(path.Text);
            song_name = file.Tag.Title;
            listBox1.Items.Add(song_name);
            songs = new string[1];
            songs[0] = file_path;
            playing_index = 0;
            //set the path that is saved to be the text for the textbox in the gui

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void volumeUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void volumeSlider_Scroll_1(object sender, EventArgs e)
        {
            Player.settings.volume = volumeSlider.Value;
            //path.Text = (volumeSlider.Value).ToString();
        }
        //testing play with button
        private void button1_Click(object sender, EventArgs e)
        {
            Player.URL = file_path;
            Player.controls.play();
            this.playBar.Image = Image.FromFile(@"C:\BearPlayer\Resources\pauseButton.png");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if( i >= 0 && i < songs.Length )
            {
                play_new_song(songs[i]);
                playing_index = i;
            }
            
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if( playing_index < songs.Length - 1)
            {
                playing_index++;
                play_new_song(songs[playing_index]);
            }
            listBox1.SelectedIndex = playing_index;
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            if (playing_index > 0)
            {
                playing_index--;
                play_new_song(songs[playing_index]);
            }
            listBox1.SelectedIndex = playing_index;
        }
    }
}
