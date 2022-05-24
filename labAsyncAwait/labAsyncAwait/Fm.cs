using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labAsyncAwait
{
    public partial class Fm : Form
    {
        public Fm()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        async private void Button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 15;i++)
            {
                await Task.Delay(300);
                button2.Text = i.ToString();
            }
            button2.Text = "end";
        }

        async private void Button1_Click(object sender, EventArgs e)
        {
            button1.Text = "думаю...";
            await Task.Delay(1000);
            button1.Text = DateTime.Now.ToString();
        }
    }
}
