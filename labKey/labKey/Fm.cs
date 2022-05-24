using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labKey
{
    public partial class Fm : Form
    {
        public Fm()
        {
            InitializeComponent();
            //
            this.KeyDown += Fm_KeyDown;
            
        }

        private void Fm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    laText.Text = "Left";
                    break;
                case Keys.Right:
                    laText.Text = "Right";
                    break;
                case Keys.Up:
                    laText.Text = "Up";
                    break;
                case Keys.Down:
                    laText.Text = "Down";
                    break;
                case Keys.Space:
                    if (e.Shift)
                    {
                        laText.Text = "Shift + space";
                    }
                    else
                    {
                        laText.Text = "Space";
                    }
                    break;
                case Keys.Z:
                    laText.Text = e.Shift ? "Shift + Z" : "Z";
                    break;
                default:
                    laText.Text = e.KeyCode.ToString();
                    break;
            }
        }
    }
}
