using labCards.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labCards
{
    public partial class Fm : Form
    {
        private Graphics g;
        private ImageBox imageBox;
        private CardPack cardPack;
        private int cardCount = 10;
        private float angle = -50.0F;
        private Point startPoint;
        private bool isVeer;

        public Fm()
        {
            InitializeComponent();

            picBox.BackgroundImage = new Bitmap(
                Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            picBox.BackgroundImageLayout = ImageLayout.None;
            g = Graphics.FromImage(picBox.BackgroundImage);

            imageBox = new ImageBox(Resources._1,4,13,13*4);

            cardPack = new CardPack(imageBox.Count);

            RandomCards();
            TSMVeer.Click += (s, e) => 
            { 
                angle = -50.0F;
                Veer();
                isVeer = true;
            };
            TSMRandom.Click += (s, e) => 
            { 
                RandomCards();
                isVeer = false;
            };
            TSMNewCards.Click += (s, e) => 
            { 
                cardPack = new CardPack(imageBox.Count);
                RandomCards();
                isVeer = false;
            };

            tbCount.Value = cardCount;
            labelCount.Text = tbCount.Value.ToString();

            tbCount.ValueChanged += (s, e) =>
            {
                cardCount = tbCount.Value;
                labelCount.Text = tbCount.Value.ToString();
                RandomCards();
            };

            picBox.MouseMove += picBox_MouseMove;
            picBox.MouseMove += (s, e) => startPoint = e.Location;
            picBox.MouseWheel += PicBox_MouseWheel;
            /*
             Рандомить карты,
             веер
             */
        }

        private void PicBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (isVeer == true)
            {
                if (e.Delta > 0)
                {
                    angle += 4.0F;
                }

                if (e.Delta < 0)
                {
                    angle -= 4.0F;
                }

                Veer();
            }
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            //startPoint = e.Location;
            Text = $"{angle}";
            if (isVeer == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (startPoint.X < e.Location.X)
                    {
                        angle += 1.0F;
                    }
                    if (startPoint.X > e.Location.X)
                    {
                        angle -= 1.0F;
                    }
                    Veer();
                }
            }
        }

        private void RandomCards()
        {
            Random rnd = new Random();
            g.Clear(SystemColors.Control);
            for (int i = 0; i < cardCount; i++)
            {
                g.DrawImage(imageBox[cardPack[i]],
                    rnd.Next(tbCount.Width,picBox.Width - imageBox[cardPack[i]].Width),
                     rnd.Next(tbCount.Height,picBox.Height - imageBox[cardPack[i]].Height)
                     );
            }
            picBox.Invalidate();
        }

        private void Veer()
        {
            Random rnd = new Random();
            g.Clear(SystemColors.Control);
            var angle_ = angle;
            for (int i = 0; i < cardCount; i++)
            {
                Matrix matr = new Matrix();
                matr.RotateAt(angle_, new PointF(Width / 2, Height / 2),MatrixOrder.Append);
                g.Transform = matr;
                angle_ += -20.0F;
                g.DrawImage(imageBox[cardPack[i]],
                     picBox.Width / 2,
                     picBox.Height / 2);
                g.ResetTransform();
                matr.Dispose();
            }
            picBox.Invalidate();
        }

    }
}
