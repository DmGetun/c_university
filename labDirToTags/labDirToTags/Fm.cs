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

namespace labDirToTags
{
    public partial class Fm : Form
    {
        private string _curDir;
        private string[] tags;
        string rez = "";
        private bool orderDesc = true;
        private string searchText = "";

        public string CurDir { 
            get
            {
                return _curDir;
            }
            private set
            {
                _curDir = value;
                edDir.Text = value;
            }
        }

        public Fm()
        {
            InitializeComponent();

            //edDir.
            //edTags

            /*
             Вход > путь к папке
             Выход > массив тегов с количеством их использования, отсортированный
             string[] tags = DirToTags("-----")
             */

            //string s = @"D:\Фото\Мосполитех\2020.01.12 Семинар ООП (Иванов,Сидоров)\202001121300-002.jpg";
            //var a = s.Split(new char[] { ' ', '\\' }).ToArray();
            //a = a.Select(v => v.TrimStart(new char[] { '(', '<' })
            //                .TrimEnd(new char[] { ')', '>' })).OrderBy(v => v).ToArray();

            //edTags.Text = string.Join(Environment.NewLine, a);

            edTags.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));


            buSelDir.Click += BuSelDir_Click;
            edDir.TextChanged += EdDir_TextChanged;
            Order.Click += (s, e) => 
            {
                edTags.Clear();
                orderDesc = false;
                SelectTags();
            };

            OrderDesc.Click += (s, e) =>
            {
                edTags.Clear();
                orderDesc = true;
                SelectTags();
            };

            this.Resize += Form1_Resize;

            tbSearch.TextChanged += TbSearch_TextChanged;
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            edTags.Clear();
            searchText = "";
            searchText = tbSearch.Text;
            SelectTags();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            edTags.Width = Width - 162;
            edTags.Height = Height - 247;

            edDir.Width = Width - 293;
            buSelDir.Location = new Point(Width - 207,buSelDir.Location.Y);
        }

        private void EdDir_TextChanged(object sender, EventArgs e)
        { 
            try
            {
                DirectoryInfo info = new DirectoryInfo(edDir.Text);
                if (info.Exists)
                {
                    edTags.Clear();
                    rez = "";
                    CurDir = edDir.Text;
                    GetTags();
                }
            }
            catch
            {

            }
        }

        private string[] DirToTags(string dir)
        {
            var info = new DirectoryInfo(dir);
            rez += $"{info.Name}\\";
            foreach (var item in info.GetFiles())
            {
                rez += item.Name + '\\';
            }

            foreach (var item in info.GetDirectories())
            {
                rez += item.Name + '\\';
                DirToTags(Path.Combine(dir, item.Name));
            }

            var a = rez.Split(new char[] { ' ', '\\','.' }).ToArray();
            a = a.Select(v => v.TrimStart(new char[] { '(', '<' })
                            .TrimEnd(new char[] { ')', '>' })).Where(v => v != string.Empty).OrderBy(v => v).ToArray();

            return a;
        }

        private void BuSelDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                CurDir = dialog.SelectedPath;
            }
        }

        private void GetTags()
        {
            tags = DirToTags(CurDir);
            SelectTags();
        }

        private void SelectTags()
        {
            if (tags is null) return;
            var query = from tag in tags
                        group tag by tag into g
                        select new { Name = g.Key, Count = g.Count() };
            if (orderDesc == true) query = query.OrderByDescending(v => v.Count);
            else query = query.OrderBy(v => v.Count);

            foreach (var item in query)
            {
                if (searchText != "")
                {
                    if (item.Name.Contains(searchText))
                        edTags.Text += $"{item.Name} : {item.Count} {Environment.NewLine}";
                    else continue;
                }
                else
                {
                    edTags.Text += $"{item.Name} : {item.Count} {Environment.NewLine}";
                }
            }
        }
    }
}
