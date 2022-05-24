using labImageScrollHorizont.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labImageScrollHorizont
{
    public partial class Fm : Form
    {
        private Bitmap imgBG;
        private Bitmap imgFG;
        private Bitmap b;
        private Graphics g;
        private Point StartPoint;
        private int drawXBG;
        private int drawXFG;

        public Fm()
        {
            InitializeComponent();

            imgFG = Resources.fon1;
            imgBG = Resources.fon2;

            this.Height = imgBG.Height + imgFG.Height;

            b = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            g = Graphics.FromImage(b);

            this.DoubleBuffered = true;
            this.Paint += (s, e) => { UpdateBG(); e.Graphics.DrawImage(b, 0, 0); };
            this.MouseDown += (s, e) => StartPoint = e.Location;
            this.MouseMove += Fm_MouseMove;
            this.KeyPreview = true;
            this.KeyDown += Fm_KeyDown;

            /*
                Фоны,
                персонаж
             */
        }

        private void Fm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    UpdateDrawX(-5,-30);
                    break;

                case Keys.Right:
                    UpdateDrawX(5,30);
                    break;

                default:
                    break;
            }
            this.Invalidate();
        }

        private void Fm_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.Capture)
            {
                UpdateDrawX(StartPoint.X - e.X, StartPoint.X - e.X);
                StartPoint = e.Location;
                this.Invalidate();
            }
        }

        private void UpdateDrawX(int v,int c)
        {
            if (c > 0)
                c += 20;
            else if (c < 0)
                c -= 20;

            Text = $"{Application.ProductName}:{drawXBG},{v},{c}";

            drawXBG -= v;
            drawXFG -= c;
            if(drawXBG > 0)
            {
                drawXBG -= imgBG.Width;
            }
            else
            {
                if (drawXBG < -imgBG.Width)
                    drawXBG += imgBG.Width;
            }

            if (drawXFG > 0)
                drawXFG -= imgFG.Width;
            else
            {
                if (drawXFG < -imgFG.Width)
                    drawXFG += imgFG.Width;
            }
        }

        private void UpdateBG()
        {
            for (int i = 0; i < 2; i++)
            {
                g.DrawImage(imgBG, drawXBG + imgBG.Width * i, 0);
                g.DrawImage(imgFG, drawXFG + imgFG.Width * i, 0 + imgBG.Height);
            }
        }
    }
}
