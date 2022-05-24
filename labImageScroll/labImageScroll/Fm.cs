using labImageScroll.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  labImageScroll
{
    public partial class Fm : Form
    {
        private Bitmap b;
        private Point StartPoint;
        private Point CurPoint;

        public Fm()
        {
            InitializeComponent();

            b = new Bitmap(Resources._1);
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(b, CurPoint);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Capture)
            {
                CurPoint.X += e.X - StartPoint.X;
                CurPoint.Y += e.Y - StartPoint.Y;
                StartPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;
        }
    }
}
