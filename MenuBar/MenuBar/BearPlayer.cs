using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuBar
{
    public partial class BearPlayer : Form
    {
        bool play;

        public BearPlayer()
        {
            play = true;

            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;   // Opens application maximized
            InitializeComponent();
        }

        private void BearPlayer_Load(object sender, EventArgs e)
        {

        }

        private void BearPlayer_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.DimGray);
            Graphics draw = this.CreateGraphics();

            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;

            draw.FillRectangle(brush, new Rectangle(0, height - 150, width, 150));
            brush.Dispose();
            draw.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (play)
                this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + "pauseButton.png");
            else
                this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + "playButton1.png");

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
    }
}

      