using ExamApp.Properties;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp
{
    public partial class Form1 : Form
    {
        List<string> drivers = new List<string>();
        string _curDir;
        List<string[]> fileDir = new List<string[]>();
        public string SellItem { get; private set; }

        bool[] sortItems = { true, true, true, true };
        Analys analys;
        private string previousDir;
        private string nextDir;
        private Stack<string> prevDirStack = new Stack<string>();
        private Stack<string> nextDirStack = new Stack<string>();
        private int SellItemIndex;

        public string CurDir
        {
            get
            {
                return _curDir;
            }
            private set
            {
                _curDir = value;
                tbDir.Text = value;
            }
        }
        public ImageList ILargeList { get; private set; }
        public ImageList ISmallList { get; private set; }

        List<int> indexItem = new List<int>();

        Timer timer;
        ListView lv;
        private Point curPoint;

        public Form1()
        {
            InitializeComponent();
            this.Resize += (s,e) =>ResizeLv();
            analys = new Analys();
            this.Width = 1300;
            this.Height = 700;
            BindLv();
            GetDrivers();
            GetAll();
            CreateImageList();
            DrawDir();
            CreateMenuStrip();

            buBack.Click += (s, e) =>
            {
                if (prevDirStack.Count != 1)
                {
                    nextDirStack.Push(prevDirStack.Pop());
                    previousDir = prevDirStack.Pop();
                    CurDir = previousDir;
                    Text = CurDir; 
                    GetAll();
                    DrawDir();
                }
            };

            buForward.Click += (s, e) =>
            {
                if (nextDirStack.Count != 0)
                {
                    nextDir = nextDirStack.Pop();
                    CurDir = nextDir;
                    GetAll();
                    DrawDir();
                }
            };
            lvFolders.KeyDown += LvFolders_KeyDown;
            buDirSelect.Click += (s, e) =>
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    CurDir = fbd.SelectedPath;
                    GetAll();
                    DrawDir();
                }
            };
            lvFolders.MouseMove += LvFolders_MouseMove;
        }

        private void LvFolders_MouseMove(object sender, MouseEventArgs e)
        {
            curPoint = new Point(e.X, e.Y);
        }

        private void GetInfo()
        {
            var item = SellItem;
            string rez = "";
            if (Directory.Exists(item))
            {
                List<string> files = new List<string>();
                List<string[]> temp = new List<string[]>();
                DirectoryInfo info = new DirectoryInfo(item);

                foreach (var file in info.GetFiles())
                {
                    temp.Add(new string[] { $"{file.Name}", $"{file.Length}", $"{file.CreationTime}" });
                }

                temp = temp.OrderByDescending(v => int.Parse(v[1])).ToList();
                int count = 3;

                if (temp.Count < 3) count = temp.Count;
                string size = "";
                for (int i = 0; i < count; i++)
                {
                    float a = analys.NewSizeDir(long.Parse(temp[i][1]), out size);
                    files.Add($"Имя:{temp[i][0]} Размер:{a} {size}");
                }
                rez += $"Топ файлов:{Environment.NewLine}";
                foreach (var file in files)
                {
                    rez += $"{file}\n";
                }
                files.Clear();

                temp = temp.OrderBy(v => int.Parse(v[1])).ToList();
                for (int i = 0; i < count; i++)
                {
                    float a = analys.NewSizeDir(long.Parse(temp[i][1]), out size);
                    files.Add($"Имя:{temp[i][0]} Размер:{a} {size}");
                }
                rez += $"{Environment.NewLine}{Environment.NewLine}Мин по размеру файлы:{Environment.NewLine}";
                foreach (var file in files)
                {
                    rez += $"{file}\n";
                }
                files.Clear();
                rez += $"{Environment.NewLine}{Environment.NewLine}Последние 3 файла:{Environment.NewLine}";
                temp = temp.OrderByDescending(v => DateTime.Parse((v[2]))).ToList();
                for (int i = 0; i < count; i++)
                {
                    files.Add($"Имя:{temp[i][0]} Дата создания:{temp[i][2]} \n");
                }
                foreach (var file in files)
                {
                    rez += $"{file} {Environment.NewLine}";
                }
                tbInfo.Text = rez;
            }
            else return;
        }


        async private void LvFolders_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                if (SellItem is null) return;
                if (!Directory.Exists(SellItem)) return;
                analys.AnalysQ.Add(SellItem);
                await Task.Run(() => analys.StartAnalys());
                GetAll();
                DrawDir();       
            }

            if(e.KeyCode == Keys.ControlKey)
            { 
                GetInfo();
                tbInfo.Visible = !tbInfo.Visible;
                tbInfo.Location = curPoint;   
            }
        }

        private void moveMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Переименовать";
            dialog.label1.Text = "Введите новое имя:";
            dialog.textBox1.Text = SellItem.Remove(0, Path.GetDirectoryName(SellItem).Length).Replace(@"\", "");

            string newName = "";

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                newName = dialog.textBox1.Text;
            }
            else
            {
                newName = "";
            }
            dialog.Dispose();

            if (newName != "")
            {
                Directory.Move(SellItem, Path.Combine(CurDir, newName));
                DrawDir();
            }
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(SellItem);
            info.Delete(true);
            DrawDir();
        }

        private void createMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Создать";
            dialog.label1.Text = "Введите имя:";
            string path = "";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                path = dialog.textBox1.Text;
            }
            else
            {
                path = "";
            }
            dialog.Dispose();

            if (path != "")
            {
                Directory.CreateDirectory(Path.Combine(CurDir, path));
                DrawDir();
            }
        }
        private void CreateMenuStrip()
        {
            ToolStripMenuItem CreateMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem DeleteMenuItem = new ToolStripMenuItem("Удалить");
            ToolStripMenuItem MoveMenuItem = new ToolStripMenuItem("Переименовать");

            contextMenuMain.Items.AddRange(new[] { CreateMenuItem, DeleteMenuItem, MoveMenuItem });
            lvFolders.ContextMenuStrip = contextMenuMain;
            CreateMenuItem.Click += createMenuItem_Click;
            DeleteMenuItem.Click += deleteMenuItem_Click;
            MoveMenuItem.Click += moveMenuItem_Click;
        }

       

        private void BindLv()
        {
            lvFolders.Columns.Add("Имя", 250);
            lvFolders.Columns.Add("Размер", 150);
            lvFolders.Columns.Add("Файлов", 150);
            lvFolders.Columns.Add("Директорий", 150);
            lvFolders.Columns.Add("Последнее изменение", 200);
            lvFolders.Columns.Add("% родительской", 200);
            lvFolders.Columns.Add("Тип", 200);
            lvFolders.View = View.Details;
            lvFolders.ColumnClick += LvFolders_ColumnClick;
            lvFolders.ItemSelectionChanged += LvFolders_ItemSelectionChanged;
            lvFolders.DoubleClick += LvFolders_DoubleClick;

            lvDrive.Columns.Add("Диск", 50);
            lvDrive.Columns.Add("Всего", 50);
            lvDrive.Columns.Add("Занято", 50);
            lvDrive.Columns.Add("Использовано", 50);
            lvDrive.Columns.Add("Файловая система", 50);

            lvDrive.View = View.Details;

            ResizeLv();
        }

    

        private void LvFolders_DoubleClick(object sender, EventArgs e)
        {
            if(Directory.Exists(SellItem))
            {
                previousDir = CurDir;
                CurDir = SellItem;
                GetAll();
                DrawDir();
            }
            else
            {
                Process.Start(SellItem);
            }
        }

        private void CheckStack()
        {
            if (prevDirStack.Count > 1)
                buBack.ForeColor = Color.Green;
            else
                buBack.ForeColor = Color.Red;

            if (nextDirStack.Count != 0)
                buForward.ForeColor = Color.Green;
            else
                buForward.ForeColor = Color.Red;

        }

        private void LvFolders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            SellItem = Path.Combine(CurDir, e.Item.Text);
            SellItemIndex = e.ItemIndex;
            indexItem.Add(SellItemIndex);
            tbInfo.Visible = false;
        }

        private void GetAll()
        {
            fileDir.Clear();
            GetDirs();
            GetFiles();
        }

        private void LvFolders_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                sortItems[0] = !sortItems[0];
                SortByName();
            }
            if (e.Column == 2)
            {
                sortItems[1] = !sortItems[1];
                SortByFiles();
            }
            if (e.Column == 3)
            {
                sortItems[2] = !sortItems[2];
                SortByDirs();
            }
            if (e.Column == 4)
            {
                sortItems[3] = !sortItems[3];
                SortByDate();
            }

            DrawDir();
        }
        private void SortByDate()
        {
            if (sortItems[3] == false)
            {
                fileDir = fileDir.OrderByDescending(v => DateTime.Parse(v[4])).ToList();
            }
            else
            {
                fileDir = fileDir.OrderBy(v => DateTime.Parse(v[4])).ToList();
            }
        }

        private void SortByDirs()
        {
            if (sortItems[2] == false)
            {
                fileDir = fileDir.OrderByDescending(v => int.Parse(v[3])).ToList();
            }
            else
            {
                fileDir = fileDir.OrderBy(v => int.Parse(v[3])).ToList();
            }
        }
        private void SortByFiles()
        {
            if (sortItems[1] == false)
            {
                fileDir = fileDir.OrderByDescending(v => int.Parse(v[2])).ToList();
            }
            else
            {
                fileDir = fileDir.OrderBy(v => int.Parse(v[2])).ToList();
            }
        }

        private void SortByName()
        {
            if (sortItems[0] == false)
            {
                fileDir = fileDir.OrderByDescending(v => v[0]).ToList();
            }
            else
            {
                fileDir = fileDir.OrderBy(v => v[0]).ToList();
            }
        }
        private void GetFiles()
        {
            DirectoryInfo info = new DirectoryInfo(CurDir);

            foreach (var item in info.GetFiles())
            {
                try
                {
                    var file = new FileInfo(item.FullName);
                    string foldSize = "";
                    var size = analys.NewSizeDir(file.Length, out foldSize);
                    var name = file.Name;
                    var fileCount = 1;
                    var dirCount = 0;
                    var lastMod = file.LastWriteTime;
                    var parent = new DirectoryInfo(info.FullName);

                    //var percentParent = (float)size / parent.Length * 100;
                    //String.Format("0:00.00", percentParent);
                    var imgNumber = IdentType(file.Extension);

                    var str_ = new string[] { name,$"{size} {foldSize}",fileCount.ToString(),
                    dirCount.ToString(),lastMod.ToString(), null,
                    $"Файл {file.Extension.Replace(".","")}"};
                    fileDir.Add(str_);
                }

                catch (UnauthorizedAccessException)
                {
                    continue;
                }

            }
        }

        private int IdentType(string ext)
        {
            if (ext != "")
                ext = ext.Remove(0, 1);

            switch (ext)
            {
                case "exe":
                    return 0;

                case "png":
                    return 3;

                case "jpg":
                    return 3;

                case "pdf":
                    return 4;

                case "docx":
                    return 5;

                case "txt":
                    return 6;

                case "zip":
                    return 7;

                case "rar":
                    return 7;

                case "":
                    return 1;

                default:
                    return 2;
            }
        }

        private void CreateImageList()
        {
            ILargeList = new ImageList();
            ISmallList = new ImageList();

            ILargeList.ImageSize = new Size(128, 128);
            ISmallList.ImageSize = new Size(16, 16);

            ILargeList.ColorDepth = ColorDepth.Depth32Bit;
            ISmallList.ColorDepth = ColorDepth.Depth32Bit;

            AddImgList();

            lvFolders.SmallImageList = ISmallList;
            lvFolders.LargeImageList = ILargeList;
        }
        private void AddImgList()
        {
            ILargeList.Images.Add(Resources.exe);
            ILargeList.Images.Add(Resources.folder_light_blue);
            ILargeList.Images.Add(Resources.folder);
            ILargeList.Images.Add(Resources.image);
            ILargeList.Images.Add(Resources.PDF);
            ILargeList.Images.Add(Resources.Word);
            ILargeList.Images.Add(Resources.bloknot);
            ILargeList.Images.Add(Resources.archive);
            //
            ISmallList.Images.Add(Resources.exe);
            ISmallList.Images.Add(Resources.folder);
            ISmallList.Images.Add(Resources.folder_light_blue);
            ISmallList.Images.Add(Resources.image);
            ISmallList.Images.Add(Resources.PDF);
            ISmallList.Images.Add(Resources.Word);
            ISmallList.Images.Add(Resources.bloknot);
            ISmallList.Images.Add(Resources.archive);
        }

        private void GetDirs()
        {
            DirectoryInfo info = new DirectoryInfo(CurDir);
            foreach (var item in info.GetDirectories())
            {
                if (analys.dict.ContainsKey(item.FullName))
                {
                    var t = analys.dict[item.FullName];
                    var str_ = new string[] {
                        t["name"],
                        t["size"],
                        t["fileCount"],
                        t["dirCount"],
                        t["lastMod"],
                        t["percentParent"],
                        t["type"]};
                    fileDir.Add(str_);
                }
                else
                {
                    try
                    {
                        var file = new FileInfo(item.FullName);
                        var name = file.Name;
                        DirectoryInfo directoryInfo = new DirectoryInfo(item.FullName);
                        var fileCount = directoryInfo.GetFiles().Length;
                        var dirCount = directoryInfo.GetDirectories().Length;
                        var lastMod = file.LastWriteTime;
                        var parent = new DirectoryInfo(info.FullName);

                        //var percentParent = (float)size / parent.Length * 100;
                        //String.Format("0:00.00", percentParent);
                        var type = "Folder";

                        var str_ = new string[] { name,null,fileCount.ToString(),
                        dirCount.ToString(),lastMod.ToString(), null,type };
                        fileDir.Add(str_);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        continue;
                    }
                }
            }
        }
        private void DrawDir()
        {
            if(prevDirStack.Count == 0 || prevDirStack.Peek() != CurDir)
                    prevDirStack.Push(CurDir);
            CheckStack();

            lvFolders.Items.Clear();
            int imgNumber = 0;

            foreach (var item in fileDir)
            {
                FileInfo file = new FileInfo(item[0]);
                imgNumber = IdentType(file.Extension);
                lvFolders.Items.Add(new ListViewItem(item, imgNumber));
            }
        }

        private void ResizeLv()
            {
            lvBrowser.Location = new Point(0, 28);
            lvBrowser.Size = new Size(ClientSize.Width / 5, ClientSize.Height / 3 * 2);

            lvDrive.Location = new Point(0, 28 + lvBrowser.Height);
            lvDrive.Size = new Size(ClientSize.Width / 5, ClientSize.Height / 3);

            lvFolders.Location = new Point(ClientSize.Width / 5, 28);
            lvFolders.Size = new Size(ClientSize.Width / 5 * 4, ClientSize.Height);

            for (int i = 0; i < lvFolders.Columns.Count; i++)
            {
                lvFolders.Columns[i].Width = lvFolders.Width / 7;
            }

            tbDir.Size = new Size(lvFolders.Width, tbDir.Height);
        }

        private void GetDrivers()
        {
            foreach (var driver in DriveInfo.GetDrives())
            {
                string size = "байт";
                drivers.Add(driver.ToString());

                lvDrive.Items.Add(new ListViewItem(new string[] { driver.Name,
                    $"{analys.NewSizeDir(driver.TotalSize,out size)} {size}",
                    $"{analys.NewSizeDir(driver.TotalFreeSpace,out size)} {size}",
                    $"{analys.PercentDrive(driver.TotalSize,driver.TotalFreeSpace)} %",
                    driver.DriveFormat}));
            }
            CurDir = previousDir = nextDir = drivers[0];
        }
    }
}
