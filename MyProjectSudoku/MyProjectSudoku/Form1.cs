using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectSudoku
{
    public partial class Form1 : Form
    {
        private Bitmap b;
        private Graphics g;
        private float widthBox;
        private float heightBox;
        private float fwidth;
        private float fheight;
        private int width;
        private int height;
        private int size = 9;
        private Button[] buttons = new Button[9];
        private int curCol = 0;
        private int curRow = 0;
        private Font myFont;
        private float sizeFont;
        private SolidBrush myBrush;
        private string currentNumber = "1";
        DateTime t1, t2;
        Timer timer = new Timer();
        private bool clearMod = false;
        private bool gameContinue = true;
        private Settings settings;
        private Game game;

        public Form1()
        {
            InitializeComponent();

            GetSize();
            game = new Game();
            game.Start();
            settings = new Settings();

            b = new Bitmap(width, height);
            g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            TimerStart();
            BindElements();

            DrawField();
            DrawSmallPanel();
            ResizeBigPanel();
            BindSignals();
            HideButtonNumbers();
        }

        private void BindElements()
        {
            TSLabelWrong.Text = $"Ошибок: {game.WrongCount}/3";
            TSWrongLimit.BackColor = Color.FromArgb(0, 255, 127);
            TSillum.BackColor = Color.FromArgb(0, 255, 127);
            TSCheckWrong.BackColor = Color.FromArgb(0, 255, 127);
            TSHideNumbers.BackColor = Color.FromArgb(0, 255, 127);
            TSHighlightNumbers.BackColor = Color.FromArgb(0, 255, 127);
            TSLabelComp.Text = $"Сложность: Легкая";
        }
        private void GetSize()
        {
            width = picBox.Width;
            fwidth = picBox.Width;
            height = picBox.Height;
            fheight = picBox.Height;
            widthBox = fwidth / (float)size;
            heightBox = fheight / (float)size;
            sizeFont = (widthBox + heightBox) / 4.5F;
            myFont = new Font("Microsoft Sans Serif", sizeFont, FontStyle.Bold,
                GraphicsUnit.Point, ((byte)(204)));
            myBrush = new SolidBrush(Color.Black);
        }
        private void TimerStart()
        {
            timer.Interval = 500;
            timer.Tick += (s, e) =>
            {
                t2 = DateTime.Now;
                TimeSpan ts = t2 - t1;
                TSLabelTime.Text = "Время игры: " + ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString();
            };
            timer.Start();
            t1 = DateTime.Now;        
        }
        private void DrawField()
        { 
            Pen myPen = new Pen(Color.Gray, 2);
            myPen.StartCap = myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            Pen myPen2 = new Pen(Color.Black, 4);
            myPen.StartCap = myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            Pen myPen3 = new Pen(Color.Red, 3);
            myPen.StartCap = myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            g.Clear(DefaultBackColor);
            b = new Bitmap(width, height);
            g = Graphics.FromImage(b);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int i = 0; i < size; i++)
            {
                g.DrawLine(myPen, i * widthBox, 0, i * widthBox, fheight);
                g.DrawLine(myPen, 0, i * heightBox, fwidth, i * heightBox);
            }
            for(int i = 0; i < size ;i = i+3)
                for(int j = 0;j < size;j=j+3)
                {
                    g.DrawRectangle(myPen2, j * widthBox, i * heightBox, widthBox * 3, heightBox * 3);
                }

            g.DrawRectangle(myPen3, curCol * widthBox, curRow * heightBox, widthBox, heightBox);

            DrawNumbers();

            if (settings.IllumCells == true)   IlluminationCells();
            if (settings.HighSimNumbers == true)  IllumSimNumbers();
            if (settings.CheckWrong == true)   CheckWrongCells();

            picBox.Invalidate();
        }
        private void CheckWrongCells()
        {
            Color brushWrongColor = Color.FromArgb(250 / 100 * 45, 250, 0, 0);
            SolidBrush wrongBrush = new SolidBrush(brushWrongColor);
            var field = game.GetField();
            var rezField = game.GetRezField();

            for (int i =0; i < size;i++)
                for(int j =0; j < size;j++)
                {
                    if(field[i,j] != rezField[i,j] && field[i,j] != 0)
                    g.FillRectangle(wrongBrush, j * widthBox, i * heightBox, widthBox, heightBox);
                }
        }
        private void IllumSimNumbers()
        {
            Color brushColor = Color.FromArgb(250 / 100 * 65, 255, 255, 0);
            SolidBrush brush = new SolidBrush(brushColor);

            var field = game.GetField();
            var rezField = game.GetRezField();
            var number = field[curRow, curCol];

            var curRowArea = curRow / 3;
            var curColArea = curCol / 3;

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (field[i, j] != rezField[i, j]) continue;

                    if (number == field[i, j] && field[i,j] != 0)
                    {
                        if (i == curRow || j == curCol) continue;
                        if (i / 3 == curRowArea && j / 3 == curColArea) continue;
                        g.FillRectangle(brush, j * widthBox, i * heightBox, widthBox, heightBox);
                    }
                }
        }
        private void IlluminationCells()
        {
            Color brushColor = Color.FromArgb(250 / 100 * 25, 80, 80, 80);
            SolidBrush brush = new SolidBrush(brushColor);

            Color brushWrongColor = Color.FromArgb(250 / 100 * 45, 250, 0, 0);
            SolidBrush wrongBrush = new SolidBrush(brushWrongColor);

            var field = game.GetField();
            var number = field[curRow, curCol];

            // ширина
            for (int i = 0;i < size;i++)
            {
                if (settings.CheckWrong == true)
                {
                    if (number == field[curRow, i] && field[curRow,i] != 0)
                    {
                        if (i == curCol)
                        {
                            g.FillRectangle(brush, i * widthBox, curRow * heightBox, widthBox, heightBox);
                            continue;
                        }
                        g.FillRectangle(wrongBrush, i * widthBox, curRow * heightBox, widthBox, heightBox);
                    }
                    else
                        g.FillRectangle(brush, i * widthBox, curRow * heightBox, widthBox, heightBox);
                }
                else
                    g.FillRectangle(brush, i * widthBox, curRow * heightBox, widthBox, heightBox);
            }
            // высота
            for (int i = 0; i < size; i++)
            {
                if (settings.CheckWrong == true)
                {
                    if (number == field[i, curCol] && field[i, curCol] != 0)
                    {
                        if (i == curRow)
                        {
                            g.FillRectangle(brush, curCol * widthBox, i * heightBox, widthBox, heightBox);
                            continue;
                        }
                        g.FillRectangle(wrongBrush, curCol * widthBox, i * heightBox, widthBox, heightBox);
                    }
                    else
                        g.FillRectangle(brush, curCol * widthBox, i * heightBox, widthBox, heightBox);
                }
                else
                    g.FillRectangle(brush, curCol * widthBox, i * heightBox, widthBox, heightBox);
            }

            var curRowArea = curRow / 3;
            var curColArea = curCol / 3;

            curRowArea *= 3; 
            curColArea *= 3; 

            for(int i = curRowArea; i < curRowArea + 3;i++)
                for(int j = curColArea; j < curColArea + 3;j++)
                {
                    if (settings.CheckWrong == true)
                    {
                        if (number == field[i, j] && field[i, j] != 0)
                        {
                            if (curRow == i || curCol == j)
                            {
                                g.FillRectangle(brush, j * widthBox, i * heightBox, widthBox, heightBox);
                                continue;
                            }
                            g.FillRectangle(wrongBrush, j * widthBox, i * heightBox, widthBox, heightBox);
                        }
                        else
                            g.FillRectangle(brush, j * widthBox, i * heightBox, widthBox, heightBox);
                    }
                    else
                        g.FillRectangle(brush, j * widthBox, i * heightBox, widthBox, heightBox);
                }
        }
        private void DrawNumbers()
        {
            int[,] rez;
            if (gameContinue)
                rez = game.GetField();
            else
                rez = game.GetRezField();

            for(int i = 0; i < size;i++)
                for(int j = 0; j < size;j++)
                {
                    if (rez[i, j] == 0) continue;
                    g.DrawString(rez[i,j].ToString(), myFont, myBrush, j * widthBox + widthBox / 3, i * heightBox - heightBox / 15, StringFormat.GenericDefault);
                }
        }
        private void BindSignals()
        {
            picBox.Resize += (s, e) =>
            {
                width = picBox.Width;
                fwidth = picBox.Width;
                height = picBox.Height;
                fheight = picBox.Height;
                widthBox = fwidth / (float)size;
                heightBox = fheight / (float)size;

                sizeFont = (widthBox + heightBox) / 4.5F;
                myFont = new Font("Microsoft Sans Serif", sizeFont, FontStyle.Bold,
                GraphicsUnit.Point, ((byte)(204)));

                DrawField();

                ResizeSmallPanel();
                ResizeBigPanel();
            };
            picBox.Paint += (s, e) => e.Graphics.DrawImage(b, 0, 0);
            picBox.MouseMove += (s, e) =>
            {  
                if(e.X / (int)widthBox != curCol)
                { 
                    curCol = e.X / (int)widthBox;
                    if (curCol > 8) curCol = 8;
                    DrawField();
                }
                if (e.Y / (int)heightBox != curRow)
                {
                    curRow = e.Y  / (int)heightBox;
                    if (curRow > 8) curRow = 8;
                    DrawField();
                }
            };
            picBox.Click += PicBox_Click;

            TSMEasy.Click += (s, e) =>
            {
                game.Comp = 1;
                TSLabelComp.Text = "Сложность: Легкая";
                if (gameContinue == true) settings.CopyToUser();
                ResetGame();
            };
            TSMMiddle.Click += (s, e) =>
            {
                game.Comp = 2;
                TSLabelComp.Text = "Сложность: Средняя";
                if (gameContinue == true) settings.CopyToUser();
                ResetGame();
            };
            TSMHard.Click += (s, e) => 
            {
                game.Comp = 3;
                TSLabelComp.Text = "Сложность: Сложная";
                if (gameContinue == true) settings.CopyToUser();
                ResetGame();
            };

            buClear.Click += (s, e) =>
            {  
                if (clearMod == false)
                {
                    buClear.BackColor = Color.FromArgb(0,255,127);
                    clearMod = true;
                }
                else
                {
                    buClear.BackColor = SystemColors.ControlLight;
                    clearMod = false;
                }
            };

            TSWrongLimit.Click += (s, e) =>
            {
                if(settings.WrongLimit == false)
                {
                    TSWrongLimit.BackColor = Color.FromArgb(0, 255, 127);
                    settings.WrongLimit = true;
                    settings.CheckWrong = true;
                    TSCheckWrong.BackColor = Color.FromArgb(0, 255, 127);
                    TSLabelWrong.Visible = true;
                }
                else
                {
                    TSWrongLimit.BackColor = Color.FromArgb(255, 106, 106);
                    settings.WrongLimit = false;
                    TSLabelWrong.Visible = false;
                }
            };

            TSillum.Click += (s, e) =>
            {
                if (settings.IllumCells == false)
                {
                    TSillum.BackColor = Color.FromArgb(0, 255, 127);
                    settings.IllumCells = true;
                }
                else
                {
                    TSillum.BackColor = Color.FromArgb(255, 106, 106);
                    settings.IllumCells = false;
                }
                DrawField();
            };

            TSCheckWrong.Click += (s, e) =>
            {
                if (settings.CheckWrong == false)
                {
                    TSCheckWrong.BackColor = Color.FromArgb(0, 255, 127);
                    settings.CheckWrong = true;
                }
                else
                {
                    TSCheckWrong.BackColor = Color.FromArgb(255, 106, 106);
                    TSWrongLimit.BackColor = Color.FromArgb(255, 106, 106);
                    settings.CheckWrong = false;
                    settings.WrongLimit = false;
                    TSLabelWrong.Visible = false;
                }
            };

            TSHideNumbers.Click += (s, e) =>
            {
                if (settings.HideNumbers == false)
                {
                    TSHideNumbers.BackColor = Color.FromArgb(0, 255, 127);
                    settings.HideNumbers = true;
                    HideButtonNumbers(); 
                }
                else
                {
                    foreach (var button in buttons) button.Visible = true;
                    TSHideNumbers.BackColor = Color.FromArgb(255, 106, 106);
                    settings.HideNumbers = false;
                }
            };

            TSHighlightNumbers.Click += (s, e) =>
            {
                if (settings.HighSimNumbers == false)
                {
                    TSHighlightNumbers.BackColor = Color.FromArgb(0, 255, 127);
                    settings.HighSimNumbers = true;
                }
                else
                {
                    TSHighlightNumbers.BackColor = Color.FromArgb(255, 106, 106);
                    settings.HighSimNumbers = false;
                }
            };

            TSRools.Click += (s, e) =>
            {
                string rools = "В судоку играют на квадратном поле 9 на 9 клеток.\n " +
                               "Само поле поделено на районы (квадраты 3 на 3)\n" +
                               "В начале игры известны некоторое число цифр в определенных клетках\n" +
                               "Цель судоку заполнить все пустые клетки с помощью цифр 1-9 (по одной цифре на клетку),\n " +
                               "по следующим правилам:\n" +
                               "1. Цифра может появиться только один раз в каждой строчке\n" +
                               "2. Цифра может появиться только один раз в каждом столбике\n" +
                               "3. Цифра может появиться только один раз в каждом районе\n" +
                               "Проще говоря, одна и та же цифра может появиться только один раз в каждой строчке, столбике и районе\n" +
                               "Вот и всё. Теперь ты готов разгадывать головоломки судоку!";
                 
                MessageBox.Show(rools);
            };

            buCancel.Click += (s, e) =>
            {
                game.CancelMove();
                DrawField();
            };
        }
        private void ResetGame()
        {
            foreach (var btn in buttons)
                btn.Visible = true;

            gameContinue = true;
            settings.CopyFromUser();
            game.Restart();
            TSLabelWrong.Text = $"Ошибок: {game.WrongCount}/3";
            
            DrawField();
            TimerStart();
        }
        private void PicBox_Click(object sender, EventArgs e)
        {
            if (gameContinue)
            {
                    if (clearMod == false)
                    {
                        if (currentNumber == "") return;

                        if (game.AddNumber(currentNumber, curRow, curCol))
                            DrawField();
                        else
                        {
                            if (settings.WrongLimit == true)
                            {
                                TSLabelWrong.Text = $"Ошибок: {game.WrongCount}/3";
                                if(game.CheckLose()) 
                                    Lose();
                            }
                            DrawField();
                        }
                    }
                    else
                    {
                        game.DeleteNumber(curRow, curCol);
                        DrawField();
                    }           
                if (settings.HideNumbers == true)
                    HideButtonNumbers();
            }
            else
                MessageBox.Show("Пожалуйста,начните новую игру.");

            if(game.CheckWin() && gameContinue)
            {
                MessageBox.Show("Поздравляю,вы победили!");
                gameContinue = false;
            }
        }
        private void Lose()
        {
                MessageBox.Show("Вы проиграли.\n" +
                    "Сейчас вам будет показано готовое поле.");
                settings.CopyToUser();
                gameContinue = false;
                settings.IllumCells = false;
                settings.CheckWrong = false;
                settings.HighSimNumbers = false;
                 DrawField();

        }
        private void HideButtonNumbers()
        {
            foreach (var button in buttons)
            {
                button.Visible = true;
            }

            var field = game.GetField();
            int count = 0;

            for (int k = 1; k < 10; k++)
            {
                count = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (k == field[i, j])
                        {
                            count++;
                        }
                    } 
                }
                if (count >= 9)
                {
                    buttons[k - 1].Visible = false;
                    buttons[k - 1].BackColor = SystemColors.ControlLight;
                    if (currentNumber == buttons[k - 1].Text)
                        currentNumber = "";
                }
            }
        }
        private void ResizeBigPanel()
        {
            buClear.Width = PanBig.Width / 2 - 10;
            buCancel.Width = PanBig.Width / 2  - 10;

            buCancel.Location = new Point(3, 8);
            buClear.Location = new Point(3 + buClear.Width + 10, 8);
        }
        private void ResizeSmallPanel()
        {
            var width = PanSmall.Width / 9;
            var height = PanSmall.Height;

            for(int i = 0;i < 9;i++)
            {
                buttons[i].Width = width;
                buttons[i].Height = height;
                buttons[i].Location = new Point(i * width, 0);
            }
        }
        private void DrawSmallPanel()
        {
            var width = PanSmall.Width / 9;
            var height = PanSmall.Height;
            for (int i = 1; i < 10; i++)
            {
                var btn = new Button();
                btn.Height = height;
                btn.Width = width;
                btn.Text = i.ToString();
                btn.Location = new Point((i - 1) * width, 0);
                btn.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular,
                    GraphicsUnit.Point, ((byte)(204)));
                btn.Click += (s, e) =>
                {
                    if (s is Button but)
                    {
                        foreach (var button in buttons)
                        {
                            button.BackColor = SystemColors.ControlLight;
                        }

                        currentNumber = but.Text;
                        but.BackColor = Color.FromArgb(186,85,211);
                    }
                    
                };
                buttons[i - 1] = btn;
                PanSmall.Controls.Add(btn);
            }
                buttons[0].BackColor = Color.FromArgb(186, 85, 211);
        }   
    }
}
