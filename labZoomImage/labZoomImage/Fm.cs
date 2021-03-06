using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labZoomImage
{
    public partial class Fm : Form
    {
        public int DeltaZoom { get; private set; } = 50;

        public Fm()
        {
            InitializeComponent();
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseWheel += PictureBox1_MouseWheel;
            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            // режим работы картинки с ZOOM
            BindSignals();
        }

        private void BindSignals()
        {
            TSMAutoSize.Click += (s, e) => pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            TSMCenterImage.Click += (s, e) => pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            TSMNormal.Click += (s, e) => pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            TSMStretch.Click += (s, e) => pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            TSMZoom.Click += (s, e) => pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            DeltaZoom += e.Delta > 0 ? 2 : -2;
            PictureBox1_MouseMove(sender,e);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"({e.X},{e.Y})";

            var xPoint = e.Location;
            if (pictureBox1.SizeMode == PictureBoxSizeMode.Zoom)
            {
                xPoint.X = e.X * pictureBox1.Image.Width / pictureBox1.Width;
                xPoint.Y = e.Y * pictureBox1.Image.Height / pictureBox1.Height;
            }

            if (pictureBox1.SizeMode == PictureBoxSizeMode.CenterImage)
            {
                xPoint.X = e.X * pictureBox1.Image.Width / pictureBox1.Width;
                xPoint.Y = e.Y * pictureBox1.Image.Height / pictureBox1.Height;
            }
            var g = Graphics.FromImage(pictureBox2.Image);
            g.Clear(DefaultBackColor);
            g.DrawImage(pictureBox1.Image,
                new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height),
                //new Rectangle(xPoint.X - 50, xPoint.Y - 50, 100, 100),
                new Rectangle(xPoint.X - DeltaZoom, xPoint.Y - DeltaZoom, DeltaZoom * 2, DeltaZoom * 2),
                GraphicsUnit.Pixel
                );
            g.Dispose();
            pictureBox2.Refresh();
        }
    }
}
