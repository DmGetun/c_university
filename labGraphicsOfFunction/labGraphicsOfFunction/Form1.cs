using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGraphicsOfFunction
{
    public partial class Form1 : Form
    {
        private Bitmap b;
        private Graphics g;
        private int height;
        private int width;
        private Stack<int> stackX = new Stack<int>();
        private Stack<int> stackY = new Stack<int>();
        private Pen myPen;

        public int CenterX { get; private set; }
        public int CenterY { get; private set; }

        public Form1()
        {
            InitializeComponent();

            DrawField();
            CreateSignals();

            labelCoords.Text = $"A={tbA.Value}      B={tbB.Value}       C={tbC.Value}";
            labelA.Text = $"A={tbA.Value}";
            labelB.Text = $"B={tbB.Value}";
            labelC.Text = $"C={tbC.Value}";
            string[] mass = 
                { "y=ax^2+bx+c",
                  "y = a|x - b| + c",
                  "y = a√x + b",
                  "y = (a/(x+b)) + c"
                };
            cbFunctions.Text = "y=ax^2+bx+c";
            cbFunctions.Items.AddRange(mass);

            myPen = new Pen(Color.Red,2);
            myPen.StartCap = myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            DrawGraphics();
        }      
        private void DrawGraphics()
        {
            ShowBars();
            var function = cbFunctions.Text;
            var a = -tbA.Value;
            var b = tbB.Value;
            var c = tbC.Value;

            if (function == "y=ax^2+bx+c")
                DrawParabola(a,b,c);

            if (function == "y = a|x - b| + c")
                DrawLines(a,b,c);

            if (function == "y = a√x + b")
            {
                tbC.Visible = false;
                labelC.Visible = false;
                DrawParabolaVetv(a, b);
            }

            if (function == "y = (a/(x+b)) + c")
                DrawGiperbola(a,b,c);


            picBox.Invalidate();
        }

        private void DrawGiperbola(int a, int b, int c)
        {
            if (a < 0)
            {
                var assimptX = 0 - b;
                var assimptY = c;
                var centX = CenterX - (picBox.Width / 20) * assimptX;
                var centY = CenterY + (picBox.Height / 20) * assimptY;

                Rectangle rect = new Rectangle(centX, centY, picBox.Width , picBox.Height );

                // Create start and sweep angles on ellipse.
                float startAngle = 180.0F;
                float sweepAngle = 90.0F;

                // Draw arc to screen.
                g.DrawArc(myPen, rect, startAngle, sweepAngle);

                centX = CenterX + (picBox.Width / 20) * assimptX - CenterX - 100;
                centY = CenterY - (picBox.Height / 20) * assimptY - CenterY - 100;

                rect = new Rectangle(centX, centY, picBox.Width, picBox.Height);
                startAngle = 0.0F;
                sweepAngle = 90.0F;

                g.DrawArc(myPen, rect, startAngle, sweepAngle);
            }
        }

        private void ShowBars()
        {
            labelA.Visible = true;
            labelB.Visible = true;
            labelC.Visible = true;

            tbA.Visible = true;
            tbB.Visible = true;
            tbC.Visible = true;

        }

        private void DrawParabolaVetv(int a, int b)
        {
            var x = 0;

            var centY = CenterY - (picBox.Height / 20) * b;
            for (int i = 0; i < 50; i++)
            {
                var y = Convert.ToInt32(a * Math.Sqrt(i) + b);

                var y2 = Convert.ToInt32(a * Math.Sqrt(x++) + b);
                g.DrawLine(myPen, CenterX + i, centY + y, CenterX + x, centY + y2);
            }
        }

        private void DrawLines(int a, int b, int c)
        {
            var x = -50;
            var centX = CenterX + (picBox.Width / 20) * b;
            var centY = CenterY - (picBox.Height / 20) * c;
            for(int i = -51;i < 50;i++)
            {
                var y = a * Math.Abs(i - b) + c;
                var y2 = a * Math.Abs((x++) - b) + c;
                g.DrawLine(myPen, centX + i, centY + y, centX + x, centY + y2);
            }
        }

        private void DrawParabola(int a,int b, int c)
        {
            var x = -50;

            for (int i = 0; i < 100; i++)
            {
                var y = a * x * x + b * x + c;
                var x2 = x + 1;
                var y2 = a * x2 * x2 + b * x2 + c;
                g.DrawLine(myPen, x * 10 + CenterX, y * 10 + CenterY, x2 * 10 + CenterX, y2 * 10 + CenterY);
                x++;

            }
        }

        private void CreateSignals()
        {
            picBox.MouseMove += (s, e) =>
            {
                this.Text = $"{ProductName}: x={e.X},y={e.Y}";
            };
            this.Resize += (s, e) =>
            {
                g.Clear(DefaultBackColor);
                DrawField();
                DrawGraphics();
            };
            picBox.Paint += (s, e) => e.Graphics.DrawImage(b, 0, 0);
            tbA.ValueChanged += Tb_ValueChanged;
            tbB.ValueChanged += Tb_ValueChanged;
            tbC.ValueChanged += Tb_ValueChanged;
            cbFunctions.SelectedValueChanged += (s, e) =>
            {
                g.Clear(DefaultBackColor);
                DrawField();
                DrawGraphics();
            };
        }

        private void Tb_ValueChanged(object sender, EventArgs e)
        {
            labelCoords.Text = $"A={tbA.Value}      B={tbB.Value}       C={tbC.Value}";
            labelA.Text = $"A={tbA.Value}";
            labelB.Text = $"B={tbB.Value}";
            labelC.Text = $"C={tbC.Value}";

            g.Clear(DefaultBackColor);
            DrawField();
            DrawGraphics();
        }

        private void DrawField()
        {
             b = new Bitmap(picBox.Width, picBox.Height);
             g = Graphics.FromImage(b);
             g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
             height = picBox.Height;
             width = picBox.Width;

            var height_ = picBox.Height / 20;
            var width_ = picBox.Width / 20;
            CenterX = width_ * 10;
            CenterY = height_ * 10;

            for (int i = 0; i < width; i = i + width_)
                g.DrawLine(new Pen(Color.Gray, 1), i, 0, i, height);
            for (int i = 0; i < height; i = i + height_)
                g.DrawLine(new Pen(Color.Gray, 1), 0, i, width, i);
            g.DrawLine(new Pen(Color.Black, 3), CenterX, 0, CenterX, height);
            g.DrawLine(new Pen(Color.Black, 3), 0,CenterY,width,CenterY);
            picBox.Invalidate();
        }

    }
}
