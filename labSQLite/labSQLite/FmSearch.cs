using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labSQLite
{
    public partial class FmSearch : Form
    {
        public FmSearch()
        {
            InitializeComponent();

            button1.DialogResult = DialogResult.OK;
            dmTable.SelectedValueChanged += DmTable_SelectedValueChanged;
            dmTable.Text = dmTable.Items[0].ToString();
        }

        private void DmTable_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cb)
            {
                if (cb.SelectedItem.ToString() == "Users")
                {
                    laAgePriority.Text = "Age";
                    laFIOCaption.Text = "FIO";
                }
                else
                {
                    laAgePriority.Text = "Priority";
                    laFIOCaption.Text = "Caption";
                }
            }
        }
    }
}
