﻿using System;
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
<<<<<<< HEAD
=======
            play = true;

>>>>>>> c7f0e88401065373f3cc2d0c31250a164ba8491d
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;   // Opens application maximized
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
