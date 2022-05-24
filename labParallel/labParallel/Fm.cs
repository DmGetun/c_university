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

namespace labParallel
{
    public partial class Fm : Form
    {
        private int countFiles = 100;

        public Fm()
        {
            InitializeComponent();

            edDirTemp.Text = Path.Combine(Path.GetTempPath(),Application.ProductName);
            Directory.CreateDirectory(edDirTemp.Text);

            buCreateFiles.Click += BuCreateFiles_Click;
            buDeleteFiles.Click += BuDeleteFiles_Click;
            button3.Click += Button3_Click;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Parallel.Invoke(
                () => {/*Задача 1*/ },
                () => {/*Задача 2*/ },
                () => {/*Задача 3*/ },
                () => {/*Задача 4*/ }
                );
        }

        private void BuDeleteFiles_Click(object sender, EventArgs e)
        {
            Parallel.For(0, countFiles, (v) => File.Delete(Path.Combine(edDirTemp.Text, $"file{v:000}.txt")));
        }

        private void BuCreateFiles_Click(object sender, EventArgs e)
        {
            Parallel.For(0, countFiles, CreateFile);
        }

        private void CreateFile(int v)
        {
            File.Create(Path.Combine(edDirTemp.Text, $"file{v:000}.txt")).Close();
        }
    }
}
