using labGenPassword.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGenPassword
{
    public partial class Fm : Form
    {
        public Fm()
        {
            InitializeComponent();
            buPassword.Click += delegate
            {
                edPassword.Text = Utils.RandomStr((int)edLength.Value,
                    ckLower.Checked, ckUpp.Checked, ckNumber.Checked, ckSpec.Checked);
            };
        }
    }
}
