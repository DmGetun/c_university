using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labFileExplorerOnWB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            edDir.Text = Directory.GetCurrentDirectory();
            buBack.Click += (s, e) => WB.GoBack();
            buForward.Click += (s, e) => WB.GoForward();
            buUp.Click += (s, e) => WB.Url  = new Uri(Directory.GetParent(edDir.Text).ToString());
            buDirSelect.Click += BuDirSelect_Click;

            WB.DocumentCompleted += (s, e) => edDir.Text = WB.Url.LocalPath;

            WB.Url = new Uri(edDir.Text);
        }

        private void BuDirSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                WB.Url = new Uri(dialog.SelectedPath);
            }
        }
    }
}
