using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;
            if(sender is PictureBox pBox)
            {
                if(pBox.Capture)
                    pictureBox1.Location = new Point(StartPoint.X - e.Location.X,StartPoint.Y - e.Location.Y);
            }
        }

        public Point StartPoint { get; private set; }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;
        }
    }
}
