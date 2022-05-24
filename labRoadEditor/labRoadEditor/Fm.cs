using labRoadEditor.Properties;
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
    public partial class Fm : Form
    {
        private Panel menu,imgZone,bigImg,SelectPanel;
        private PictureBox field;
        private PictureBox[,] picBox;
        private List<PictureBox> picOnRoad = new List<PictureBox>();
        private Bitmap b;
        private string tagImg;
        private bool isSelect = false;
        private Point StartPoint;
        Road road;
        public Dictionary<string, PictureBox> dictpBox;
        private float fCellHeight,fCellWidth;

        public int Rows  = 5;
        public int Cols  = 5;
        private bool isDown = false;
        private bool isDownRight = false;
        private int startWidth;
        private int startHeight;

        public int CurCol { get; private set; }
        public int CurRow { get; private set; }
        public int CellHeight { get; private set; }
        public int CellWidth { get; private set; }
        public int ZoomDiff { get; private set; } = 5;

        public Fm()
        {
            InitializeComponent();
            road = new Road(Rows, Cols);
            road.StartDraw();
            DrawField();
            BingSignals();
            string mes = "\t\t\tДобро пожаловать!\t\t\n" +
                "Кнопка сохранить используется для сохранения текущего состояния дороги(выберите папку и в ней" +
                " будет создан файл Road{Количество строк}_{Количество столбцов}\n" +
                "Кнопка загрузить используется для загрузки сохраненной дороги\n" +
                "Кнопка новое поле позволяет пересоздать поле с новым размером\n" +
                "Кнопка залить поле картинкой используется для размещения выбранной картинки во все ячейки(" +
                "картинка должна быть выбрана)\n" +
                "Очистить поле очищает поле\n" +
                "Для рисования дороги выберите картинку(выбранная картинка помечается зеленым)\n" +
                "Для удаления нарисованой части дороги отмените выбор картинки(нажатием правой " +
                "кнопкой мыши по полю выбора картинок) и кликните левой кнопкой мыши по той части, которую" +
                "необходимо удалить\n" +
                "Удерживая левую кнопку мыши, водите по полю для рисования дороги.";
            MessageBox.Show(mes);
        }

        private void BingSignals()
        {
            this.Resize += Fm_Resize;
            field.Paint += Field_Paint;
            field.MouseMove += Field_MouseMove;
            field.MouseClick += Field_MouseClick;
            field.MouseWheel += Field_MouseWheel;
            field.MouseDown += Field_MouseDown;
            field.MouseUp += Field_MouseUp;
            TSMSave.Click += (s, e) => { road.SaveRoad(); };
            SelectPanel = new Panel
            {
                BackColor = Color.FromArgb(100, Color.Green),
                Visible = false
            };
            TSMDownload.Click += (s, e) =>
            {
                string temp = road.DownloadRoad();
                if (temp != "") MessageBox.Show(temp);
                else DrawRoad();
            };

            TSMNewField.Click += (s, e) =>
            {
                FormSize FS = new FormSize();
                bool flag;
                if (FS.ShowDialog() != DialogResult.Cancel)
                {
                    flag = FS.returnSize(out Rows, out Cols);
                    if (flag) MessageBox.Show("Одно из полей пустое.\nУстановлен размер 5x5");
                    road = new Road(Rows, Cols);
                    CellWidth = field.Width / Cols;
                    CellHeight = field.Height / Rows;
                    road.StartDraw();
                    DrawRoad();
                }
                else return;
            };
            TSMFill.Click += (s, e) =>
            {
                if (tagImg == null)
                {
                    MessageBox.Show("Не выбрана картинка");
                }
                else
                {
                    for (int i = 0; i < Rows; i++)
                        for (int j = 0; j < Cols; j++)
                            road.AddToRoad(tagImg, i, j);
                    DrawRoad();
                }
            };
            TSMClear.Click += (s, e) =>
             {
                 road.StartDraw();
                 DrawRoad();
             };

            SelectPanel.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    tagImg = null;
                    isSelect = false;
                    SelectPanel.Visible = false;
                    SelectPanel.Parent = null;
                }
            };
        }

        private void Field_MouseUp(object sender, MouseEventArgs e)
        { 
            if (e.Button == MouseButtons.Left)
                isDown = false;
            if (e.Button == MouseButtons.Right)
                isDownRight = false;
        }

        private void Field_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
            if (e.Button == MouseButtons.Left)
                isDown = true;
            if (e.Button == MouseButtons.Right)
                isDownRight = true;
        }

        private void Field_MouseWheel(object sender, MouseEventArgs e)
        {

            int xDelta = e.Delta > 0 ? 5 : -5;
            if (sender is Control x)
            {
                x.Location = new Point(x.Location.X + xDelta * -1, x.Location.Y + xDelta * -1);
                x.Width += xDelta * 2;
                x.Height += xDelta * 2;
            }
            DrawRoad();
        }

        private void Field_MouseClick(object sender, MouseEventArgs e)
        {
            var X = e.X;
            var Y = e.Y;
            var ro = road.ReturnRoad();
            if (e.Button == MouseButtons.Left)
            {
                CurCol = X / CellWidth;
                CurRow = Y / CellHeight;
                if (ro[CurRow, CurCol] == "n")
                {
                    if (tagImg == null) return;
                    var posX = CellWidth * CurCol;
                    var posY = CellHeight * CurRow;

                    var imgWidth = CellWidth;
                    var imgHeight = CellHeight;

                    int i, j;
                    road.GetCoords(tagImg, out i, out j);                 

                    road.AddToRoad(tagImg, CurRow, CurCol);
                    DrawRoad();
                }
                else if (ro[CurRow,CurCol] != "n")
                {
                    if (tagImg != null) return;
                    road.DeleteFromRoad(CurRow, CurCol);
                    DrawRoad();
                }
            }
        }
     
        private void Field_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b, new Point(0, 0));
        }

        private void Field_MouseMove(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;
            CurCol = X / CellWidth;
            CurRow = Y  / CellHeight;
            if (CurCol >= Cols || CurRow >= Rows) return;

            var matr = road.ReturnRoad();

            if(isDown)
            {
                if (tagImg == null) return;
                if (matr[CurRow, CurCol] != "n") return; 
                matr[CurRow, CurCol] = tagImg;
            }

            if (e.Button == MouseButtons.Right)
            {
                Point x = new Point(Cursor.Position.X - StartPoint.X, Cursor.Position.Y - StartPoint.Y);
                if (sender is Control)
                    ((Control)sender).Location = PointToClient(x);
            }
                DrawRoad();
        }

        private void Fm_Resize(object sender, EventArgs e)
        {
            ResizeMenu();
            ResizeField();
            ResizeImgZone();
            ResizeBigImg();
            ResizeSmallImg();
        }

        private void ResizeBigImg()
        {
            bigImg.Height = menu.Height / 2;
            bigImg.Width = menu.Width;
        }

        private void ResizeImgZone()
        {
            var Rows = 3;
            var Cols = 4;
            imgZone.Height = menu.Height / 2;
            imgZone.Width = menu.Width;
            imgZone.Location = new Point(0, menu.Height / 2);  
        }

        private void ResizeField()
        {
            field.Width = ClientSize.Width - menu.Width;
            field.Height = ClientSize.Height - TSM.Height;
            field.Location = new Point(menu.Width, 0 + TSM.Height);

            CellWidth = field.Width / Cols;
            CellHeight = field.Height / Rows;

            fCellWidth = (float)field.Width / Cols;
            fCellHeight = (float)field.Height / Rows;

            //DrawRoad();
        }

        private void ResizeMenu()
        {
            menu.Width = ClientSize.Width / 3;
            menu.Height = ClientSize.Height;
        }

        private void DrawField()
        {
            menu = new Panel();
            field = new PictureBox();
            imgZone = new Panel();
            bigImg = new Panel();

            menu.BorderStyle = BorderStyle.FixedSingle;
            field.BorderStyle = BorderStyle.FixedSingle;
            imgZone.BorderStyle = BorderStyle.FixedSingle;
            bigImg.BorderStyle = BorderStyle.FixedSingle;
            bigImg.BackgroundImageLayout = ImageLayout.Stretch;

            ResizeMenu();

            ResizeField();

            startWidth = ClientSize.Width - menu.Width;
            startHeight = ClientSize.Height - TSM.Height;

            ResizeImgZone();

            ResizeBigImg();

            ShowImg();

            ResizeSmallImg();

            this.Controls.Add(menu);
            this.Controls.Add(field);
            menu.Controls.Add(imgZone);
            menu.Controls.Add(bigImg);
        }

        private void DrawRoad()
        { 
            CellHeight = field.Height / Rows;
            CellWidth = field.Width / Cols;
            fCellWidth = (float)field.Width / Cols;
            fCellHeight = (float)field.Height / Rows;
            b = new Bitmap(field.Width,field.Height);

            using (var g = Graphics.FromImage(b))
            {
                g.Clear(DefaultBackColor);
                for (int i = 0; i <= Rows; i++)
                {
                    g.DrawLine(new Pen(Color.Green, 1), 0, i * CellHeight, Cols * CellWidth, i * CellHeight);
                }
                for (int j = 0; j <= Cols; j++)
                {
                    g.DrawLine(new Pen(Color.Green, 1), j * CellWidth, 0, j * CellWidth, Rows * CellHeight);
                }
                g.DrawRectangle(new Pen(Color.Red, 3), CurCol * CellWidth, CurRow * CellHeight,
                        CellWidth, CellHeight);
            }
            AddImageOnRoad();
            field.Invalidate();
        }

        private void AddImageOnRoad()
        {
            int posX, posY;

            string[,] ro = road.ReturnRoad();
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    if (ro[i, j] == "n") continue;

                    posX = j * CellWidth;
                    posY = i * CellHeight;
                    var g = Graphics.FromImage(b);
                    g.DrawImage(dictpBox[ro[i,j]].Image,
                        posX, posY, CellWidth, CellHeight);
                }
        }

        private void ResizeSmallImg()
        {
            var Rows = 3;
            var Cols = 4;
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    picBox[i,j].Width = imgZone.Width / Cols;
                    picBox[i, j].Height = imgZone.Height / Rows;
                    picBox[i, j].Location = new Point(j * picBox[i, j].Width, i * picBox[i, j].Height);

                }
        }

        private Image[,] GetImage()
        {
            var Rows = 3;
            var Cols = 4; 
            var imgarray = new Image[Rows,Cols];
            var img = Resources.Road;
            var imgWidth = img.Width / Cols;
            var imgHeight = img.Height / Rows;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    imgarray[i,j] = new Bitmap(imgWidth , imgHeight );
                    var graphics = Graphics.FromImage(imgarray[i,j]);
                    graphics.DrawImage(img, new Rectangle(0, 0, imgWidth , imgHeight ), new Rectangle(j * imgWidth , i * imgHeight , imgWidth , imgHeight ), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            return imgarray;
        }

        private void ShowImg()
        {
            var Rows = 3;
            var Cols = 4;
            picBox = new PictureBox[Rows, Cols];
            dictpBox = new Dictionary<string, PictureBox>(Rows * Cols);
            var img = GetImage();
            string tags = "123456789abc";

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    PictureBox pBox = new PictureBox();
                    pBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pBox.Image = img[i, j];
                    pBox.Tag = tags[i * Cols + j];
                    pBox.BorderStyle = BorderStyle.Fixed3D;
                    pBox.MouseMove += PBox_MouseMove;
                    pBox.MouseClick += PBox_MouseClick;
                    picBox[i, j] = pBox;
                    dictpBox[pBox.Tag.ToString()] = pBox;
                    imgZone.Controls.Add(picBox[i,j]);
                }
             
        }

        private void PBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pBox)
            {
                if (e.Button == MouseButtons.Left)
                {
                    tagImg = pBox.Tag.ToString();
                    isSelect = true;
                    bigImg.BackgroundImage = pBox.Image;
                }
                else
                {
                    tagImg = null;
                    isSelect = false;
                }
            }
        }

        private void PBox_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (sender is PictureBox pBox)
            {   
                if(!isSelect)
                    bigImg.BackgroundImage = pBox.Image;

                var panel = new Panel
                {
                    Parent = pBox,
                    BackColor = Color.FromArgb(100, Color.Red),
                    //Dock = DockStyle.Fill
                    Size = pBox.Image.Size,
                    Tag = pBox.Tag
                };
                panel.MouseLeave += Panel_MouseLeave;
                panel.MouseClick += Panel_MouseClick;
            }

        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is Panel pb)
            {
                if (e.Button == MouseButtons.Left)
                {
                    tagImg = pb.Tag.ToString();
                    bigImg.BackgroundImage = dictpBox[tagImg].Image;
                    isSelect = true;
                    pb.BackColor = Color.FromArgb(100, Color.Green);
                    SelectPanel.Parent = pb.Parent;
                    SelectPanel.Visible = true;
                }

                if (e.Button == MouseButtons.Right)
                {
                    tagImg = null;
                    isSelect = false;
                    SelectPanel.Visible = false;
                    SelectPanel.Parent = null;
                }
            }
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel pn)
                pn.Visible = false;
        }
    }
}
