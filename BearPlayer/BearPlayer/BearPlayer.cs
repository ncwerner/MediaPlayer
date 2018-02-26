using System;
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
    public partial class BearPlayer : Form
    {
        bool play = true;   // Global variable for controling play/pause state
        string file_path;   // directory of chosed song
        string folder_path;   // Directory address to folder
        string song_name; //song name pulled from imported file
        WMPLib.WindowsMediaPlayer Player;   //player object from WMP library

        public BearPlayer()
        {
            InitializeComponent();
            Player = new WMPLib.WindowsMediaPlayer();

            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;   // Opens application maximized
            
            // Set minimum window size for application 
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void BearPlayer_Load(object sender, EventArgs e)
        {
   
        }

        public bool Get_Play() { return play; }  // Accessor for play state
        public void Change_PlayState() { play = !play; }   // Back-end function to change play state

        public void Set_FilePath(string path) { file_path = path;  }   // Mutator for file path
        public string Get_FilePath() { return file_path;  }   // Accessor for file path

        public void Set_FolderPath(string path) { folder_path = path; }   // Mutator for folder path
        public string Get_FolderPath() { return folder_path;  }   // Accessor for folder path

        public void Set_Song_Name(string name) { song_name = name;  }  // Mutator for song name
        public string Get_Song_Name() { return song_name; }   // Accessor for song name


        // Function that returns the address of a specified picture
        public String Get_Picture(int choice)
        {
            switch (choice)
            {
                case 0: return @"C:\BearPlayer\Resources\playButton1.png";
                case 1: return @"C:\BearPlayer\Resources\pauseButton.png";
                default: return null; 
            }
        }


        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (play)
            {
                this.playBar.Image = Image.FromFile(Get_Picture(1));
                if (Player.URL != file_path)
                {
                    Player.URL = file_path;
                }
                //sets the URL for the player as the file path
                Player.controls.play();
                //plays the file that is currently set as the URL
            }
            else
            {
                this.playBar.Image = Image.FromFile(Get_Picture(0));
                Player.controls.pause(); // SHOULD BE CHANGED TO PAUSE EVENTUALLY BUT CURRENTLY PAUSE CAUSES IT TO REPEAT IMMEDIATELY
            }

            Change_PlayState();  // Alternate play-pause button
        }


        // Import Folder
        public void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folder_path = "";
            //initializes the folder path
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Set_FolderPath(@folderDialog.SelectedPath);
                    //saves the selected folder as folder path
                }
            }
            path.Text = Get_FolderPath();
            //shows the path in the text box
        }

        // Import song
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
                Set_FilePath(@openFileDialog1.FileName);

            path.Text = Get_FilePath();

            //get song name from file
            TagLib.File file = TagLib.File.Create(path.Text);
            Set_Song_Name(file.Tag.Title);
            SongName.Text = Get_Song_Name();

            //set the path that is saved to be the text for the textbox in the gui

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {   this.Close();   }


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
            Player.URL = Get_FilePath();
            Player.controls.play();
            this.playBar.Image = Image.FromFile(Get_Picture(1));
        }
    }
}
