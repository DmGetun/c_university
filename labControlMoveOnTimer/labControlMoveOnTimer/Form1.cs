using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labControlMoveOnTimer
{
    public partial class Form1 : Form
    {
        private int deltaX = 4;

        public Form1()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 100; // 1000 = 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

            this.MouseWheel += (s,e) => deltaX += (e.Delta > 0) ? 1 : -1;
            this.MouseClick += (s, e) => timer.Enabled = !timer.Enabled;
        }

        

        private void Timer_Tick(object sender, EventArgs e)
        {
            var x = pictureBox1;
            if ((x.Location.X + deltaX + x.Width > ClientSize.Width) || (x.Location.X + deltaX < 0))
            {
                deltaX *= - 1;
            }
            x.Location = new Point(x.Location.X + deltaX, x.Location.Y);
            Text = $"{Application.ProductName} {x.Location.X} {deltaX}, {x.Width}, {ClientSize.Width}";
        }
    }
}
