using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabEvent3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //
            button2.Click += button2_Click;
            //
            button3.Click += button2_Click;
            //
            button3.Click += delegate
            {
                MessageBox.Show("Способ 3");
            };
            //
            button4.Click += (sender, e) => MessageBox.Show("Способ 4");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Способ 2");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Способ 1");
        }
    }
}
