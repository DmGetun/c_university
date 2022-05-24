using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labCreateControlOnMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var x = new Label();
                x.Location = e.Location;
                //x.Text = String.Format("({0},{1})", e.X, e.Y);
                x.Text = $"({e.X},{e.Y})";
                x.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                x.ForeColor = Color.Red;
                this.Controls.Add(x);
            }

            if (e.Button == MouseButtons.Right)
            {
                var rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                var x = new Label();
                x.Location = new Point(rnd.Next(Size.Width), rnd.Next(Size.Height));
                //x.Text = String.Format("({0},{1})", e.X, e.Y);
                x.Text = $"({x.Location.X},{x.Location.Y})";
                x.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                x.ForeColor = Color.Blue;
                x.AutoSize = true;
                this.Controls.Add(x);
                }
                
            }
        }
    }
}
