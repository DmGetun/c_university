﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //
            button1.Click += Button1_Click;
            button2.Click += Button1_Click;
            label1.Click += Button1_Click;
            label2.Click += Button1_Click;
            button3.Click += Button3_Click;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (sender is Control)
                (sender as Control).Text = "click";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (sender is Control)
                MessageBox.Show(((Control)sender).Text);
        }
    }
    
}
