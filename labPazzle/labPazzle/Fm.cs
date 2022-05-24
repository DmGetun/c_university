using labPazzle.Properties;
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

namespace labPazzle
{
    public partial class Fm : Form
    {

        public int Rows { get; private set; } = 3;
        public int Cols { get; private set; } = 4;
        public Point StartPoint;
        public bool flagDownImage = false;
        public bool flagVisionBox = false;

        private PictureBox[,] pics;
        
        /*
             * Загрузить другую картинку +
             * новое деление картинки + 
             * масштабировать исходную картинку
             * автодоведение картинок +
             * и другое
        */

        public Fm()
        {
            InitializeComponent();

            CreateCells();
            CreateTable();
            ResizeTable();
            InputSize();

            StartLocationCells();
            ResizeCells();
            this.Resize += (s, e) =>
            {
                ResizeCells();
                StartLocationCells();
            };
            this.Text += "   F1 - Собрать, F2 - Перемешать, F3 - Новый размер" +
                " F4 - загрузить картинку F5 - размер поля";
            this.KeyDown += Fm_KeyDown;
        }

        private void ResizeTable()
        {
            var tlp = (TableLayoutPanel)Controls[Controls.Count - 1];
            var Height = ClientSize.Height / Rows;
            var Width = ClientSize.Width / Cols;

            for (int i = 0; i < tlp.RowCount; i++)
            {
                tlp.RowStyles[i].Height = Height;
            }

            for (int j = 0; j < tlp.ColumnCount; j++)
            {
                tlp.ColumnStyles[j].Width = Width;
            }
        }

        private void CreateTable()
        {
            var tlp = new TableLayoutPanel();
            tlp.RowCount = Rows;
            tlp.ColumnCount = Cols;
            
            tlp.Dock = DockStyle.Fill;

            var Height = ClientSize.Height / Rows;
            var Width = ClientSize.Width / Cols;
            for (int i = 0; i < Rows; i++)
            {
                tlp.RowStyles.Add(new RowStyle());
                tlp.RowStyles[i].SizeType = SizeType.Absolute;
                tlp.RowStyles[i].Height = Height;
            }
                
            for(int j = 0; j < Cols;j++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle());
                tlp.ColumnStyles[j].SizeType = SizeType.Absolute;
                tlp.ColumnStyles[j].Width = Width;
            }
            this.Controls.Add(tlp);
        }

        private void InputSize()
        {
            var grpbox = new GroupBox();
            
            grpbox.Location = new Point(ClientSize.Width / 2,ClientSize.Height / 2);
            if (flagVisionBox == false) grpbox.Visible = false;
            else grpbox.Visible = true;
            grpbox.Name = "grpbox";

            var text = new TextBox();
            var text2 = new TextBox();

            var label = new Label();
            label.Text = "Ширина";
            label.Name = "laWidth";
            label.Location = new Point(grpbox.Width - 180, grpbox.Height - 80);
            var label2 = new Label();
            label2.Text = "Высота";
            label2.Location = new Point(grpbox.Width - 180, grpbox.Height - 50);
            label2.Name = "laHeight";

            text.Location = new Point(grpbox.Width - 110, grpbox.Height - 80);
            text2.Location = new Point(grpbox.Width - 110, grpbox.Height - 50);

            var btn = new Button();
            btn.Text = "Ok";
            btn.Location = new Point(grpbox.Width - 180, grpbox.Height - 25);
            btn.Click += (s, e) => Rows = int.Parse(text.Text);
            btn.Click += (s, e) => Cols = int.Parse(text2.Text);
            btn.Click += (s, e) => grpbox.Visible = false;
            btn.Click += (s, e) => CreateCells();
            btn.Click += (s, e) => StartLocationCells();
            btn.Click += (s, e) => ResizeCells();

            var btn2 = new Button();
            btn2.Text = "Отмена";
            btn2.Location = new Point(grpbox.Width - 90, grpbox.Height - 25);
            btn2.Click += (s, e) => grpbox.Visible = false;

            grpbox.Controls.Add(text);
            grpbox.Controls.Add(text2);
            grpbox.Controls.Add(label);
            grpbox.Controls.Add(label2);
            grpbox.Controls.Add(btn);
            grpbox.Controls.Add(btn2);

            this.Controls.Add(grpbox);
            grpbox.BringToFront();
        }

        private Bitmap OpenFile()
        {
            Bitmap image = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                image = new Bitmap(ofd.FileName);
                return image;
            }
            return image;
        }
        private void Fm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    StartLocationCells();
                    break;

                case Keys.F2:
                    RandowCells();
                    break;

                case Keys.F3:
                    StartLocationCells();
                    ResizeCells();
                    break;

                case Keys.F4:
                    flagDownImage = true;
                    ResizeCells();
                    flagDownImage = false;
                    break;

                case Keys.F5:
                    flagVisionBox = true;
                    InputSize();
                    flagVisionBox = false;
                    break;
            }
        }

        private void RandowCells()
        {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    pics[i, j].Location = new Point(
                        rnd.Next(ClientSize.Width - pics[i, j].Width),
                        rnd.Next(ClientSize.Height - pics[i, j].Height));
                }
        }

        private void ResizeCells()
        {
            int xCellWidth = this.ClientSize.Width / Cols;
            int xCellHeight = this.ClientSize.Height / Rows;
            var img = GetImage();
            if(flagDownImage == true)
            {
                var imageFromFile = OpenFile();
                img = GetImage(imageFromFile);
            }

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    pics[i, j].Width = xCellWidth;
                    pics[i, j].Height = xCellHeight;
                    pics[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    pics[i, j].Image = img[i, j];
                }
        }
        private Image[,] GetImage(Bitmap image = null)
        {
            var imgarray = new Image[Rows,Cols];
            Image img;
            
            if(image != null)
                img = image;
            else
                img = (Image)Properties.Resources.ResourceManager.GetObject("_1");

            var imgHeight = img.Height;
            var imgWidth = img.Width;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    imgarray[i,j] = new Bitmap(imgWidth / Cols, imgHeight / Rows);
                    var graphics = Graphics.FromImage(imgarray[i,j]);
                    graphics.DrawImage(img, 
                        new Rectangle(0, 0, imgWidth / Cols, imgHeight / Rows), 
                        new Rectangle(j * (imgWidth / Cols), i * (imgHeight / Rows), imgWidth / Cols, imgHeight / Rows), 
                        GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }
            return imgarray;
        }

        private void StartLocationCells()
        {
            int xCellWidth = this.ClientSize.Width / Cols;
            int xCellHeight = this.ClientSize.Height / Rows;

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    pics[i, j].Location = new Point(j * xCellWidth, i * xCellHeight);
                }
        }

        private void CreateCells()
        {
            Controls.Clear();
            pics = new PictureBox[Rows, Cols];
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                {
                    pics[i, j] = new PictureBox();
                    pics[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pics[i, j].MouseDown += PictureBoxAll_MouseDowm;
                    pics[i, j].MouseMove += PictureBoxAll_MouseMove;
                    pics[i, j].MouseUp += PictureBoxAll_MouseUp;
                    this.Controls.Add(pics[i, j]);
                }
        }

        private void PictureBoxAll_MouseUp(object sender, MouseEventArgs e)
        { 
            if(sender is PictureBox pb)
            {
                int curRow, curCol;
                Point PointClient = PointToClient(Cursor.Position);
                curCol = PointClient.X / pb.Width;
                curRow = PointClient.Y  / pb.Height;
                pb.Location = new Point(curCol  * pb.Width, curRow * pb.Height);
            }
        }

        private void PictureBoxAll_MouseMove(object sender, MouseEventArgs e)
        {
            if ( e.Button == MouseButtons.Left)
            {
                Point xPoint = new Point(Cursor.Position.X - StartPoint.X, Cursor.Position.Y - StartPoint.Y);
                if (sender is Control x)
                {
                    x.BringToFront();
                    x.Location = PointToClient(xPoint);
                }
            }
        }

        private void PictureBoxAll_MouseDowm(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }    
    }
}
