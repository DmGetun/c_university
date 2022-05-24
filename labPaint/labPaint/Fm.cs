using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labPaint
{
    public partial class Fm : Form
    {
        private bool isPressed;
        private Image im;
        private Color mainColor;
        private Color addColor;
        private string figure = "line";
        private Panel pan;
        private Graphics g;
        private Pen myPen;
        private Point curPoint;

        public Fm()
        {
            InitializeComponent();
            pan = new Panel();
            mainColor = pxColorMain.BackColor;
            addColor = pxColorAdd.BackColor;
            DrawPanel();
            myPen = new Pen(mainColor,tbWidth.Value);
            myPen.StartCap = myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            im = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            g = Graphics.FromImage(im);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            laWidth.Text = tbWidth.Value.ToString();
            tbWidth.ValueChanged += (s, e) => { myPen.Width = tbWidth.Value;laWidth.Text = tbWidth.Value.ToString(); };

            pxImage.MouseMove += PxImage_MouseMove;
            pxImage.MouseDown += (s, e) => {
                curPoint = e.Location;
                if (e.Button == MouseButtons.Left)
                    myPen.Color = mainColor;
                if (e.Button == MouseButtons.Right)
                    myPen.Color = addColor;
            };

            pxImage.Paint += (s, e) => e.Graphics.DrawImage(im, 0, 0);

            pxColorMain.MouseClick += PxColor_MouseClick;
            pxColorAdd.MouseClick += PxColorAdd_MouseClick;

            buSave.Click += BuSave_Click;
            buLoad.Click += BuLoad_Click;
            buClear.Click += (s, e) =>
            {
                g.Clear(DefaultBackColor);
                pxImage.Invalidate();
            };
            /*
             минимальный функционал paint-a;
             Изменение размера формы;
             */
        }

        private void PxColorAdd_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = pxColorMain.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pxColorAdd.BackColor = dialog.Color;
                addColor = dialog.Color;
            }
        }

        private void DrawPanel()
        {

            var img = new Bitmap(pxLine.Width, pxLine.Height);
            var g = Graphics.FromImage(img);
            g.DrawLine(new Pen(Color.Black,5),
                new Point(10,pxLine.Height/2),
                new Point(pxLine.Width - 10,pxLine.Height/2));
            pxLine.Image = img;
            pxLine.Click += Px_Click;
            pxLine.Click += (s, e) =>
            {
                figure = "line";
            };

            g.Dispose();

            img = new Bitmap(pxRect.Width, pxRect.Height);

            g = Graphics.FromImage(img);
            g.DrawRectangle(new Pen(Color.Black, 3),
                new Rectangle(10, 10, pxRect.Width - 20, pxRect.Height - 20)
                );
            pxRect.Image = img;
            pxRect.Click += Px_Click;
            pxRect.Click += (s, e) =>
            {
                figure = "rectangle";
            };
        }

        private void Px_Click(object sender, EventArgs e)
        {
            if(sender is PictureBox pBox)
            {
                pan.Width = pBox.Width;
                pan.Height = pBox.Height;
                pan.Parent = pBox;
                pan.BorderStyle = BorderStyle.FixedSingle;
                pan.BackColor = Color.FromArgb(100, Color.Green);
            }
        }

        private void BuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                im = Bitmap.FromFile(dialog.FileName);
            }
        }

        private void BuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                im.Save(dialog.FileName);
            }
        }

        private void PxColor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = pxColorMain.BackColor;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                pxColorMain.BackColor = dialog.Color;
                mainColor = dialog.Color;
            }
        }

        private void PxImage_MouseMove(object sender, MouseEventArgs e)
        {
            switch (figure)
            {
                case "line":
                    drawLine(e);
                    break;
                case "rectangle":
                    drawRectangle(e);
                    break;
            }
        }

        private void drawRectangle(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                g.DrawRectangle(myPen, curPoint.X,curPoint.Y,e.Location.X - curPoint.X,e.Location.Y - curPoint.Y);
                pxImage.Invalidate();
            }
        }

        private void drawLine(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                g.DrawLine(myPen, curPoint, e.Location);
                curPoint = e.Location;
                pxImage.Invalidate();
            }
        }

        private void PaImage_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(im, new Point(0, 0));
        }

        private void PaImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isPressed) return;

            var g = Graphics.FromImage(im);
            g.DrawLine(new Pen(Color.Red, 5),
                e.X - 10, e.Y - 10, e.X + 10, e.Y + 10);
            g.DrawLine(new Pen(Color.Red, 5),
                e.X - 10, e.Y + 10, e.X + 10, e.Y - 10);
            g.Dispose();
            pxImage.CreateGraphics().DrawImage(im, new Point(0, 0));
        }

        private void PaImage_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void PaImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isPressed = true;
        }
    }
}
