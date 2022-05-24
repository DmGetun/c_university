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
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();

            //this.IsMdiContainer = true;

            MIcreateNewForm.Click += delegate
            {
                var x = new FmNote();
                x.MdiParent = this;
                x.Show();
            };

            MIWindowsCascade.Click += (s, e) => this.LayoutMdi(MdiLayout.Cascade);
            MIWindowsTileHor.Click += (s, e) => this.LayoutMdi(MdiLayout.TileHorizontal);
            MIWindowsTileVert.Click += (s, e) => this.LayoutMdi(MdiLayout.TileVertical);
            MIWindowsArrange.Click += (s, e) => this.LayoutMdi(MdiLayout.ArrangeIcons);

            MICloseActiveForm.Click += (s, e) => this.ActiveMdiChild?.Close();
            closeAllFormsToolStripMenuItem.Click += delegate
            {
                while (this.MdiChildren.Count() > 0)
                {
                    this.MdiChildren[0].Close();
                }
            };

            MIAbout.Click += (s, e) => new FmAbout().ShowDialog();
        }
    }
}
