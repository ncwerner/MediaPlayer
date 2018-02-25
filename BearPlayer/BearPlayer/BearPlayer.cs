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
        bool play;   // Global variable for controling play/pause state

        public BearPlayer()
        {
            InitializeComponent();
            play = true;   // Begin program with play button
            
        }

        private void BearPlayer_Load(object sender, EventArgs e)
        {
   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (play)
                this.playBar.Image = Image.FromFile(Application.StartupPath + "\\" + "pauseButton.png");

            else
                this.playBar.Image = Image.FromFile(Application.StartupPath + "\\" + "playButton1.png");

            play = !play;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string folder_path = "";
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {

                    folder_path = folderDialog.SelectedPath;
                }
            }
            path.Text = folder_path;
        }

        private void importSongToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Music Files| *.mp3";
            openFileDialog1.Title = "Select a Song";
            string file_path = "";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                file_path = openFileDialog1.FileName;

            }
            path.Text = file_path;
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
