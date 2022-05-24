using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGif
{
    public partial class fm : Form
    {
        public fm()
        {
            InitializeComponent();
            //
            button1.Click += delegate
            {
                pictureBox1.Enabled = !pictureBox1.Enabled;
            };

            button2.Click += delegate
            {
                pictureBox2.Enabled = !pictureBox2.Enabled;
            };
        }
    }
}
