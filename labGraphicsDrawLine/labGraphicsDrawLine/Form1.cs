using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGraphicsDrawLine
{
    public partial class Form1 : Form
    {
        private Bitmap b;
        private Graphics g;
        private Point startPoint;
        private Pen myPen;

        public Form1()
        {
            InitializeComponent();

            b = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            myPen = new Pen(Color.Red, 5);
            myPen.StartCap = myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            pxImage.MouseDown += (s, e) => startPoint = e.Location;
            pxImage.MouseMove += PxImage_MouseMove;
            pxImage.Paint += (s, e) => e.Graphics.DrawImage(b, 0, 0);

            pxColor1.Click += (s, e) => myPen.Color = pxColor1.BackColor;
            pxColor2.Click += (s, e) => myPen.Color = pxColor2.BackColor;
            pxColor3.Click += (s, e) => myPen.Color = pxColor3.BackColor;
            pxColor4.Click += (s, e) => myPen.Color = pxColor4.BackColor;

            trPenWidth.Value = Convert.ToInt32(myPen.Width);
            trPenWidth.ValueChanged += (s, e) => myPen.Width = trPenWidth.Value;

            buClear.Click += (s, e) =>
            {
                g.Clear(DefaultBackColor);
                pxImage.Invalidate();
            };
        }

        private void PxImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(myPen, startPoint, e.Location);
                startPoint = e.Location;
                pxImage.Invalidate();
            }
        }
    }
}
