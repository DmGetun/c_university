using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTrainerAccount
{
    public partial class Fm : Form
    {
        int comp = 1;
        private Games g;
        public Fm()
        {
            InitializeComponent();
            g = new Games();
            g.Change += Event_Change;
            g.DoReset(1);

            rBut1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rBut2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            rBut3.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            buYes.Click += (sender, e) => g.DoAnswer(true,comp);
            buNo.Click += (sender, e) => g.DoAnswer(false,comp);
        }


        private void Event_Change(object sender, EventArgs e)
        {
            laCorrect.Text = String.Format("Верно = {0}", g.CountCorrect.ToString());
            laWrong.Text = String.Format("Неверно = {0}", g.CountWrong.ToString());
            laCode.Text = g.CodeText;
        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rBut1.Checked)
            {
                comp = 1;
                g.DoContinue(1);
            }
            else if (rBut2.Checked)
            {
                comp = 2;
                g.DoContinue(2);
            }
            else if (rBut3.Checked)
            {
                comp = 3;
                g.DoContinue(3);
            }
        }

        private void butRes_Click(object sender, EventArgs e)
        {
            g.DoReset(comp);
        }
    }
}
