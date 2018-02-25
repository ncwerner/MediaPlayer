﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BearPlayer
{
    public partial class Bear_Player : Form
    {
        public bool play = true;   // Global variable for controling play/pause state
        string file_path;   // directory of chosed song
        string song_name; //song name pulled from imported file
        WMPLib.WindowsMediaPlayer Player;   //player object from WMP library

        public Bear_Player()
        { 
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;   // Opens application maximized
            InitializeComponent();
            Player = new WMPLib.WindowsMediaPlayer();
        }

        private void BearPlayer_Load(object sender, EventArgs e)
        {
   
        }

        // Method to return address of specificed picture picture
        public String Get_Picture(int choice) {
            switch (choice)
            {
                case 0: return "\\pauseButton.png"; 
                case 1: return "\\playButton1.png"; 
                default: return null;
            }
        }

        // Method to change play-pause state variable
        public void Change_Play_State(){
            play = !play;
        }


        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(play)
            {
                this.playBar.Image = Image.FromFile(Application.StartupPath + Get_Picture(0));   // Change picture to pause
                if (Player.URL != file_path)
                    Player.URL = file_path;
                
                //sets the URL for the player as the file path
                Player.controls.play();
                //plays the file that is currently set as the URL
            }
            else
            {
                this.playBar.Image = Image.FromFile(Application.StartupPath + Get_Picture(1));   // Change picture to play
                Player.controls.pause(); // SHOULD BE CHANGED TO PAUSE EVENTUALLY BUT CURRENTLY PAUSE CAUSES IT TO REPEAT IMMEDIATELY
            }

            Change_Play_State();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
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
            SongName.Text = song_name;
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
            this.playBar.Image = Image.FromFile(Application.StartupPath + Get_Picture(0));   // Change picture to pause
        }
    }
}
