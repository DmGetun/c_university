using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        Bitmap b;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            b = new Bitmap(100, 100);
            g = Graphics.FromImage(b);

            pictureBox1.Paint += PictureBox1_Paint;
            pictureBox1.Click += PictureBox1_Click;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var g = Graphics.FromImage(b);
            g.DrawLine(new Pen(Color.Black, 5), 0, 0, 100, 100);
            pictureBox1.Invalidate();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b,0,0);
        }
    }
}
