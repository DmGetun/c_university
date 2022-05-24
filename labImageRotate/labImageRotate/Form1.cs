using labImageRotate.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labImageRotate
{
    public partial class Form1 : Form
    {
        private Bitmap b;

        public Form1()
        {
            InitializeComponent();

            b = new Bitmap(Resources._1);
            trackBar1.ValueChanged += (s, e) => pictureBox1.Invalidate();
            pictureBox1.Paint += PictureBox1_Paint;

            button1.Click += (s, e) => 
            {
                b.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Invalidate();
            };
            button2.Click += (s, e) =>
            {
                b.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Invalidate();
            };

            //! pictureBox1.Image.RotateFlip
            // TODO rotateflip, вращение от разных углов, точек
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(b.Width / 2, b.Height / 2);
            e.Graphics.RotateTransform(trackBar1.Value);
            e.Graphics.DrawImage(b, -b.Width/2, -b.Height / 2);
        }
    }
}
