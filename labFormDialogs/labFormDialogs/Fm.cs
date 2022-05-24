using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labFormDialogs
{
    public partial class Fm : Form
    {
        public Fm()
        {
            InitializeComponent();

            buOpenDialog.Click += BuOpenDialog_Click;
            /*
             рассмотреть остальные диалоговые окна;
             */
        }

        private void BuOpenDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.InitialDirectory = openDialog.Text;
            //openFileDialog.Filter = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openDialog.Text = openFileDialog.FileName;
            }
            
            
        }
    }
}
