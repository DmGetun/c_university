using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labImageOnTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //List<PictureBox> list = new List<PictureBox>();
            var list = new List<PictureBox>();
            list.Add(pictureBox1);
            list.Add(pictureBox2);
            list.Add(pictureBox3);
            list.Add(pictureBox4);
            list.Add(pictureBox5);
            list.Add(pictureBox6);
            list.Add(pictureBox7);
            list.Add(pictureBox8);
            list.Add(pictureBox9);

            pictureBox2.Image = imageList1.Images[0];

            int i = 0;
            foreach (var x in list)
            {
                x.Image = imageList1.Images[0];
                x.Tag = ++i;
                x.MouseEnter += PictureBoxAll_MouseEnter;
                x.MouseLeave += PuctureBoxAll_MouseLeave;
            }
        }

        private void PuctureBoxAll_MouseLeave(object sender, EventArgs e)
        {
         //   if (sender is PictureBox)
         //       ((PictureBox)sender).Image = imageList1.Images[0];

            if (sender is PictureBox x)
                x.Image = imageList1.Images[0];
        }

        private void PictureBoxAll_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox x)
                x.Image = imageList1.Images[Convert.ToInt32(x.Tag)];
        }
    }
}
