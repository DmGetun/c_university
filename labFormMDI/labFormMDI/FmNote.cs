using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labFormMDI
{
    public partial class FmNote : Form
    {
        public FmNote()
        {
            InitializeComponent();

            Text += $"{DateTime.Now.ToString()}";
        }
    }
}
