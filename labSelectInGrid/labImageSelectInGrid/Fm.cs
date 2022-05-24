using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labImageSelectInGrid
{
    public partial class Fm : Form
    {
        private Bitmap b;

        public int Rows { get; private set; } = 3;
        public int Cols { get; private set; } = 4;
        public int CellWidth { get; private set; }
        public int CellHeight { get; private set; }
        public int CurRow { get; private set; }
        public int CurCol { get; private set; }

        public Fm()
        {
            InitializeComponent();

            ResizeCells();
            DrawCells();

            pxImage2.MouseMove += PxImage_MouseMove;
            pxImage2.Paint += (s, e) => e.Graphics.DrawImage(b, 0, 0);
            pxImage2.Resize += (s, e) =>
             {
                 ResizeCells(); 
                 pxImage2.Invalidate();
             };

            trRows.Minimum = 1;
            trRows.Maximum = 10;

            trCols.Minimum = 1;
            trCols.Maximum = 10;

            trRows.Value = Rows;
            trCols.Value = Cols;

            trRows.ValueChanged += (s, e) =>
            {
                Rows = trRows.Value;
                ResizeCells();
                pxImage2.Invalidate();
            };

            trCols.ValueChanged += (s, e) =>
            {
                Cols = trCols.Value;
                ResizeCells();
                pxImage2.Invalidate();
            };

            this.Paint += Fm_Paint;
            this.Resize += Fm_Resize;
            this.MouseMove += Fm_MouseMove;
        }

        

        private void PxImage_MouseMove(object sender, MouseEventArgs e)
        {
            CurRow = e.Y / CellHeight;
            CurCol = e.X / CellWidth;
            Text = $"{CurRow},{CurCol}";
            DrawCells();
            pxImage2.CreateGraphics().DrawImage(b, new Point(0, 0));
        }

        private void Fm_MouseMove(object sender, MouseEventArgs e)
        {
            CurRow = e.Y / CellHeight;
            CurCol = e.X / CellWidth;
            Text = $"{CurRow},{CurCol}";
            DrawCells();
            this.CreateGraphics().DrawImage(b, new Point(0, 0));
        }

        private void Fm_Resize(object sender, EventArgs e)
        {
            ResizeCells();
            DrawCells();
            this.CreateGraphics().DrawImage(b, new Point(0, 0));
        }

        private void Fm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(b, new Point(0, 0));
        }

        private void DrawCells()
        {
            //var g = Graphics.FromImage(b);
            // ...
            //g.Dispose();
            using (var g = Graphics.FromImage(b))
            {
                g.Clear(DefaultBackColor);
                for (int i = 0; i < Rows; i++)
                {
                    g.DrawLine(new Pen(Color.Green, 1),0, i * CellHeight,Cols * CellWidth,i * CellHeight);
                }
                for (int j = 0; j < Cols; j++)
                {
                    g.DrawLine(new Pen(Color.Green, 1), j * CellWidth, 0 , j * CellWidth, Rows * CellHeight);
                }
                g.DrawString($"{CurRow} {CurCol}",new Font("",40),new SolidBrush(Color.Black), 
                    CurCol * CellWidth, CurRow * CellHeight);
                g.DrawRectangle(new Pen(Color.Red, 3), CurCol * CellWidth, CurRow * CellHeight,
                    CellWidth, CellHeight);
            }
        }

        private void ResizeCells()
        {
            b = new Bitmap(Width,Height);
            CellWidth = pxImage2.Width / Cols;
            CellHeight = pxImage2.Height / Rows;
            DrawCells();
        }
    }
}
