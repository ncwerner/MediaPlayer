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
        public BearPlayer()
        {
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
    }

}
