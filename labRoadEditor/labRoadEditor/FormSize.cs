using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labRoadEditor
{
    public partial class FormSize : Form
    {
        public FormSize()
        {
            InitializeComponent();
            buOk.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public bool returnSize(out int Width, out int Height,bool flag = false)
        {
            if (TBWidth.Text != "" && TBHeight.Text != "")
            {
                Width = int.Parse(TBWidth.Text);
                Height = int.Parse(TBHeight.Text);
                return flag;
            }
            else
            {
                Width = 5;
                Height = 5;
                flag = true;
                return flag;
            }
        }
    }
}
