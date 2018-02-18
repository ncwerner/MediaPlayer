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
            InitializeComponent();
        }

        private void BearPlayer_Load(object sender, EventArgs e)
        {

        }

        private void BearPlayer_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.DimGray);
            Graphics draw = this.CreateGraphics();
            draw.FillRectangle(brush, new Rectangle(0, 555, 1065, 120));
            brush.Dispose();
            draw.Dispose();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
