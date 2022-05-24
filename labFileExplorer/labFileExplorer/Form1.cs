using labFileExplorer.Properties;
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
using System.Diagnostics;

namespace labFileExplorer
{
    public partial class Form1 : Form
    {
        private string _curDir;
        private string filterText;
        private int size = 1024;
        private string curSize = "Кбайт";

        public string CurDir {
            get {
                return _curDir;
            }
            private set {
                _curDir = value;
                edDir.Text = value;
            }
        }

        private string previousDir;
        private string nextDir;
        private Stack<string> prevDirStack = new Stack<string>();
        private Stack<string> nextDirStack = new Stack<string>();
        private string filterExt = "";
        private bool dirView = true;
        private bool fileView = true;
        private bool hiddenFile = true;
        private bool autoSize = false;
        private string[] rez;
        private string folderSize;
        private List<string> favoriteDir = new List<string>();
        private Dictionary<string, string> dictSize = new Dictionary<string, string>();

        public string SellItem { get; private set; }

        private ListViewItem favoriteItem;

        public ImageList ILargeList { get; private set; }
        public ImageList ISmallList { get; private set; }

        public Form1()
        {
            /*
                Менять картинку по расширению (f.Extension) (+)
                Менять отображаемый размер файла (+)
                добавить панель с кнопками дисков (+)
                поиск по папке (+) 
                фильтр по расширениям (+)
                отображение только папок или файлов (+)
                кнопка скрыть/ показать скрытые папки,файлы item.Attribyte (+)
                автоматический выбор размера (+)
                сортировка по именам, датам по нажатию на заголовок
                Нажатие на клавишу backspace перейти на директорию выше (+)
                создать, удалить, изменить папку (+)
                по кнопке пробел считать размер папки (+)
                избранное(избранные папки) (+)
             */

            InitializeComponent();
            ReadFromFile();
            lv.View = View.Details;
            CurDir = previousDir = nextDir = "C:\\";

            //CurDir = Directory.GetCurrentDirectory();

            CreateSignals();
            CreateImageList();
            GetDrivers();

            // создаем элементы меню
            CreateMenuStrip();

            lv.KeyDown += Lv_KeyDown;
            lv.Columns.Add("Имя", 350);
            lv.Columns.Add("Дата изменения", 150);
            lv.Columns.Add("Тип", 100);
            lv.Columns.Add("Размер", 150);
            lv.ColumnClick += Lv_ColumnClick;

            lvFavorite.Columns.Add("Избранное", lvFavorite.Width - 5);
            lvFavorite.View = View.Details;

            LoadDir(CurDir);
        }

        private void CreateMenuStrip()
        {
            ToolStripMenuItem CreateMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem DeleteMenuItem = new ToolStripMenuItem("Удалить");
            ToolStripMenuItem MoveMenuItem = new ToolStripMenuItem("Переименовать");
            ToolStripMenuItem AddMenuItem = new ToolStripMenuItem("Добавить в Избранное");

            contextMenuMain.Items.AddRange(new[] { CreateMenuItem, DeleteMenuItem, MoveMenuItem, AddMenuItem });

            ToolStripMenuItem DeleteFavoriteMenuItem = new ToolStripMenuItem("Удалить из Избранного");

            contextMenuFavorite.Items.Add(DeleteFavoriteMenuItem);

            lv.ContextMenuStrip = contextMenuMain;
            lvFavorite.ContextMenuStrip = contextMenuFavorite;

            lvFavorite.ItemSelectionChanged += LvFavorite_ItemSelectionChanged;
            lvFavorite.DoubleClick += LvFavorite_DoubleClick;
            CreateMenuItem.Click += createMenuItem_Click;
            DeleteMenuItem.Click += deleteMenuItem_Click;
            MoveMenuItem.Click += moveMenuItem_Click;
            AddMenuItem.Click += AddMenuItem_Click;
            DeleteFavoriteMenuItem.Click += DeleteFavoriteMenuItem_Click;
        }

        private void WriteToFile()
        {
            string path = "favoriteDir.txt";
            using (StreamWriter f = new StreamWriter(path,false))
            {
                foreach (var item in favoriteDir)
                {
                    f.WriteLine(item);
                }
            }
        }

        private void ReadFromFile()
        {
            string path = "favoriteDir.txt";
            
            favoriteDir.Clear();
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }

            using (StreamReader f = new StreamReader(path))
            {
                while(!f.EndOfStream)
                {
                    var line = f.ReadLine();
                    if(Directory.Exists(line) || File.Exists(line))
                        AddToFavorite(line);
                }
            }
        }

        private void DeleteFavoriteMenuItem_Click(object sender, EventArgs e)
        {
            favoriteDir.RemoveAt(favoriteItem.Index);
            lvFavorite.Items.Remove(favoriteItem);
            WriteToFile();
        }

        private void LvFavorite_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            favoriteItem = e.Item;
        }

        private void LvFavorite_DoubleClick(object sender, EventArgs e)
        {
            previousDir = CurDir;
            LoadDir(favoriteDir[favoriteItem.Index]);
        }

        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            AddToFavorite(SellItem);
            WriteToFile();
        }

        private void AddToFavorite(string item)
        {
            if (Directory.Exists(item))
            {
                favoriteDir.Add(item);
                lvFavorite.Items.Add(new ListViewItem(item.Remove(0, Path.GetDirectoryName(item).Length).Replace(@"\", ""), GetImageNumber("")));
            }
            else
            {
                favoriteDir.Add(item);
                FileInfo file = new FileInfo(item);
                lvFavorite.Items.Add(new ListViewItem(item.Remove(0, Path.GetDirectoryName(item).Length).Replace(@"\", ""), GetImageNumber(file.Extension)));
            }
        }

        private void moveMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Переименовать";
            dialog.label1.Text = "Введите новое имя:";
            dialog.textBox1.Text = SellItem.Remove(0,Path.GetDirectoryName(SellItem).Length).Replace(@"\","");

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
                LoadDir(CurDir);
            }
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(SellItem);
            info.Delete(true);
            favoriteDir.Remove(SellItem);
            lvFavorite.Items.Clear();
            WriteToFile();
            ReadFromFile();
            LoadDir(CurDir);
        }

        private void createMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Создать";
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
                Directory.CreateDirectory(Path.Combine(CurDir,path));
                LoadDir(CurDir);
            }
        }

        private void Lv_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                if (!(Directory.GetParent(CurDir) is null))
                    LoadDir(Directory.GetParent(CurDir).ToString());
            }

            if(e.KeyCode == Keys.Space)
            {
                if (SellItem is null) return;
                long size = SizeOfDirectory(SellItem);
                if (size != 0)
                {
                    float size_ = newSizeDir(size);
                    rez = new string[] { $"{SellItem}", $"{size_}" };
                    dictSize[SellItem] = $"{size_} {folderSize}";
                }
                LoadDir(CurDir);
            }
        }

        private long SizeOfDirectory(string dir)
        {
            long i = 0;
            try
            {
                DirectoryInfo DrInfo = new DirectoryInfo(dir);
                DirectoryInfo[] folder = DrInfo.GetDirectories();
                FileInfo[] Fi = DrInfo.GetFiles();
            

            foreach (FileInfo fl in Fi)
            {
                i += fl.Length;
            }

            for (int j = 0; j < folder.Length; j++)
            {
                i += SizeOfDirectory(Path.Combine(dir,folder[j].Name));
            }
                return i;
            }
            catch
            {
                MessageBox.Show("У вас нет доступа к данному каталогу");
                return 0;
            }
        }

        private float newSizeDir(long length) 
        {
            float sizeB = 0;
            if (length / 1024 >= 1)
            {
                folderSize = "Кбайт";
                sizeB = (float)(length / 1024);
            }

            if (length / 1024 / 1024 >= 1)
            {
                folderSize = "Мбайт";
                sizeB = (float)(length / 1024 / 1024);
            }

            if (length / 1024 / 1024 / 1024 > 0)
            {
                folderSize = "Гбайт";
                sizeB = (float)(length / 1024 / 1024 / 1024);
            }
            return sizeB;
        }

        private void Lv_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(e.Column == 0)
            {
                
            }   
        }

        private void GetDrivers()
        {
            foreach (var driver in Directory.GetLogicalDrives())
            {
                var but = new Button();
                but.Text = driver;
                but.Click += DriversClick;
                tsMin.Items.Add(driver, null, new EventHandler(DriversClick));
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

            lv.SmallImageList = ISmallList;
            lv.LargeImageList = ILargeList;

            lvFavorite.SmallImageList = ISmallList;
            lvFavorite.LargeImageList = ILargeList;
        }

        private void AddImgList()
        {
            ILargeList.Images.Add(Resources._0);
            ILargeList.Images.Add(Resources._1);
            ILargeList.Images.Add(Resources._2);
            ILargeList.Images.Add(Resources._3);
            ILargeList.Images.Add(Resources._4);
            ILargeList.Images.Add(Resources._5);
            ILargeList.Images.Add(Resources._6);
            ILargeList.Images.Add(Resources._7);
            //
            ISmallList.Images.Add(Resources._0);
            ISmallList.Images.Add(Resources._1);
            ISmallList.Images.Add(Resources._2);
            ISmallList.Images.Add(Resources._3);
            ISmallList.Images.Add(Resources._4);
            ISmallList.Images.Add(Resources._5);
            ISmallList.Images.Add(Resources._6);
            ISmallList.Images.Add(Resources._7);
        }

        private void DriversClick(object sender, EventArgs e)
        {
            if (sender is ToolStripButton but)
            {
                CurDir = but.Text;
                LoadDir(CurDir);
            }
        }

        private void CreateSignals()
        {
            miViewLargeIcon.Click += (s, e) => lv.View = View.LargeIcon;
            miViewSmallIcon.Click += (s, e) => lv.View = View.SmallIcon;
            miViewList.Click += (s, e) => lv.View = View.List;
            miViewDetails.Click += (s, e) => lv.View = View.Details;
            miViewTile.Click += (s, e) => lv.View = View.Tile;

            buUp.Click += (s, e) => {
                if(!(Directory.GetParent(CurDir) is null))
                    LoadDir(Directory.GetParent(CurDir).ToString());
                };

            edDir.KeyDown += EdDir_KeyDown;

            lv.ItemSelectionChanged += (s, e) => {
                SellItem = Path.Combine(CurDir, e.Item.Text);
                }; 

            lv.DoubleClick += (s, e) => {
                if (Directory.Exists(SellItem))
                {
                    previousDir = CurDir;
                    LoadDir(SellItem);
                }
                else
                {
                    Process.Start(SellItem);
                }
            };
            tbSearch.TextChanged += TbSearch_TextChanged;

            // события для изменения отображаемого размера файлов
            muItemByte.Click += (s, e) =>  { size = 1; curSize = "байт"; autoSize = false; LoadDir(CurDir); };
            muItemKbyte.Click += (s, e) => { size = 1024; curSize = "Кбайт"; autoSize = false; LoadDir(CurDir); };
            muItemMbyte.Click += (s, e) => { size = 1024 * 1024; curSize = "Мбайт"; autoSize = false; LoadDir(CurDir); };
            muItemGbyte.Click += (s, e) => { size = 1024 * 1024 * 1024; curSize = "Гбайт"; autoSize = false; LoadDir(CurDir); };
            //

            // события кнопок вперед-назад
            buBack.Click += (s, e) =>
            {
                if (prevDirStack.Count != 1)
                {
                    nextDirStack.Push(prevDirStack.Pop());
                    previousDir = prevDirStack.Pop();
                    LoadDir(previousDir);
                }
            };

            buForward.Click += (s, e) =>
            {
                if (nextDirStack.Count != 0)
                {
                    nextDir = nextDirStack.Pop();
                    LoadDir(nextDir);
                }
            };

            //
            tsFilterExt.TextChanged += (s, e) => { filterExt = tsFilterExt.Text;LoadDir(CurDir); };

            //Выбор отображения содержимого директории
            muBuAllView.Click += (s, e) =>
            {
                dirView = true;
                fileView = true;
                LoadDir(CurDir);
            };

            muBuDirView.Click += (s, e) =>
            {
                dirView = true;
                fileView = false;
                LoadDir(CurDir);
            };

            muBuFileView.Click += (s, e) =>
            {
                dirView = false;
                fileView = true;
                LoadDir(CurDir);
            };

            buDirSelect.Click += (s, e) =>
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    CurDir = fbd.SelectedPath;
                    LoadDir(CurDir);
                }
            };

            TSViewHiddenFiles.Click += (s, e) =>
            {
                if(hiddenFile == false)
                {
                    TSViewHiddenFiles.Text = "Не показывать скрытые файлы";
                    hiddenFile = true;
                }
                else
                {
                    TSViewHiddenFiles.Text = "Показать скрытые файлы";
                    hiddenFile = false;
                }
                LoadDir(CurDir);
            };

            muItemAuto.Click += (s, e) =>
            {
                autoSize = true;
                curSize = "Авто";
                LoadDir(CurDir);
            };

            buViewFavorite.Click += (s, e) =>
            {
                if(lvFavorite.Visible == true)
                {
                    buViewFavorite.Text = "Показать \"Избранное\"";
                    lvFavorite.Visible = false;
                }
                else
                {
                    buViewFavorite.Text = "Скрыть \"Избранное\"";
                    lvFavorite.Visible = true;
                }
            };
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripTextBox tBox)
            {
                filterText = tBox.Text;
                LoadDir(edDir.Text);
            }
        }

        private void EdDir_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadDir(edDir.Text);
            }
        }

        private void LoadDir(string newDir)
        {

            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(newDir);
                if(prevDirStack.Count == 0 || prevDirStack.Peek() != newDir)
                    prevDirStack.Push(newDir);

                lv.BeginUpdate();
                lv.Items.Clear();
                CheckStack();

                if (dirView == true)
                {
                    foreach (var item in directoryInfo.GetDirectories())
                    {
                        var f = new FileInfo(item.FullName);
                        var size = "";

                        //if(!(rez is null))
                        //    if (rez[0] == item.FullName)
                        //        size = rez[1] + $" {folderSize}";

                        try
                        {
                            size = dictSize[f.FullName];
                        }
                        catch
                        {
                            size = "";
                        }

                        if (hiddenFile == false)
                            if ((item.Attributes & FileAttributes.Hidden) != 0) continue;

                        if (filterText is null)
                            lv.Items.Add(new ListViewItem(new string[] { item.Name, f.LastWriteTime.ToString(), "Папка", size },
                                1));
                        else if (item.Name.ToLower().IndexOf(filterText.ToLower()) != -1)
                            lv.Items.Add(new ListViewItem(new string[] { item.Name, f.LastWriteTime.ToString(), "Папка", size },
                                1));

                    }

                }

                if (fileView == true)
                {
                    foreach (var item in directoryInfo.GetFiles())
                    {
                        var f = new FileInfo(item.FullName);

                        if (hiddenFile == false)
                            if ((item.Attributes & FileAttributes.Hidden) != 0) continue;

                        if (filterExt != "")
                        {
                            if (f.Extension.ToLower().IndexOf(filterExt.ToLower()) == -1)
                                continue;
                        }
                        float size = newSize(f.Length);
                        var im_num = GetImageNumber(f.Extension);

                        if (filterText is null)
                            lv.Items.Add(new ListViewItem(new string[] { item.Name, f.LastWriteTime.ToString(), $"Файл {f.Extension.Replace(".","")}", size.ToString() + $" {curSize}" },
                                im_num));
                        else if (item.Name.ToLower().IndexOf(filterText.ToLower()) != -1)
                            lv.Items.Add(new ListViewItem(new string[] { item.Name, f.LastWriteTime.ToString(), $"Файл {f.Extension.Replace(".","")}", size.ToString() + $" {curSize}" },
                                im_num));
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Отказано в доступе");
                prevDirStack.Pop();
                lv.EndUpdate();
                LoadDir(CurDir);

                return;
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Такого каталога нет");
                lv.EndUpdate();
                LoadDir(CurDir);

                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Неверный путь");
                lv.EndUpdate();
                CurDir = previousDir;

                return;
            }
            lv.EndUpdate();
            CurDir = newDir;
        }

        private void CheckStack()
        {
            if(prevDirStack.Count > 1)
                buBack.ForeColor = Color.Green;   
            else  
                buBack.ForeColor = Color.Red;

            if (nextDirStack.Count != 0)
                buForward.ForeColor = Color.Green;
            else
                buForward.ForeColor = Color.Red;
            
        }

        private int GetImageNumber(string ext)
        {
            if(ext != "")
                ext = ext.Remove(0, 1);

            switch(ext)
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

        private float newSize(long length)
        {
            float sizeB = length;
            if (autoSize == false)
            {
                float sizeA = (length / (float)size);
                if (curSize != "байт")
                {
                    if (sizeA > 0.5)
                        sizeA = (float)Math.Ceiling(sizeA);
                    else
                        sizeA = (float)Math.Floor(sizeA);
                }
                return sizeA;
            }
            else
            {
                if(length/1024 > 1)
                {
                    curSize = "Кбайт";
                    sizeB = (float)(length / 1024);
                }

                if(length/1024/1024 > 1)
                {
                    curSize = "Мбайт";
                    sizeB = (float)(length / 1024 / 1024);
                }

                if(length/1024/1024/1024 > 0)
                {
                    curSize = "Гбайт";
                    sizeB = (float)(length / 1024 / 1024 / 1024);
                }
                return sizeB;
            }
        }
    }
}
