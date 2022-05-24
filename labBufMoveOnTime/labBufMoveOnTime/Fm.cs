using labBufMoveOnTime.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labBufMoveOnTime
{
    public partial class Fm : Form
    {
        private BufferedGraphics buf;
        private Bitmap imHero;
        private int deltaX = 1;
        private Point pointHero = new Point(0,20);

        public Fm()
        {
            InitializeComponent();

            buf = BufferedGraphicsManager.Current.Allocate(this.CreateGraphics(),this.ClientRectangle);
            imHero = new Bitmap(Resources.smailik_ylibka_1, 128, 128);

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.DoubleBuffered = true;
            this.Paint += (s, e) => buf.Render();
            this.MouseClick += (s, e) => timer.Enabled = !timer.Enabled;
            this.MouseWheel += (s, e) => deltaX += (e.Delta > 0) ? 1 : -1;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if ((pointHero.X + deltaX + imHero.Width > ClientSize.Width) ||
                (pointHero.X + deltaX < 0))
            {
                deltaX *= -1;
            }
            pointHero = new Point(pointHero.X + deltaX, pointHero.Y);
            Text = $"{Application.ProductName} : {pointHero.X}, {deltaX}, {imHero.Width}, {ClientSize.Width}";
            buf.Graphics.Clear(SystemColors.Control);
            buf.Graphics.DrawImage(imHero, pointHero);
            buf.Render();
        }
    }
}
