using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTagGame
{
    public partial class Fm : Form
    {
        Game game;
        int view = 0;
        int size = 4;
        int comp = 1;
        string image_name = "_2";

        Button[,] btn = new Button[4, 4];
        List<PictureBox> picbox = new List<PictureBox>();
        
        public Fm()
        {
            InitializeComponent();
            grb.TabIndex = 0;
            game = new Game(4, view);
            game.start();
            DrawTable();
            BindSignals();
        }

        private void BindSignals()
        {
            Resize += rgb_resize;
            PumaTool.Click += (s, e) => image_name = "_1";
            PumaTool.Click += (s, e) => view = 1;
            PumaTool.Click += (s, e) => game.start();
            PumaTool.Click += (s, e) => DrawImageTable();

            TigrTool.Click += (s, e) => image_name = "_2";
            TigrTool.Click += (s, e) => view = 1;
            PumaTool.Click += (s, e) => game.start();
            TigrTool.Click += (s, e) => DrawImageTable();

            Puma2Tool.Click += (s, e) => image_name = "_3";
            Puma2Tool.Click += (s, e) => view = 1;
            Puma2Tool.Click += (s, e) => game.start();
            Puma2Tool.Click += (s, e) => DrawImageTable();

            TsCollectImage.Click += (s, e) => game.start();
            TsCollectImage.Click += (s, e) => fullDraw();

            TlEasy.Click += (s, e) => comp = 1;
            TlMid.Click += (s, e) => comp = 2;
            TlHard.Click += (s, e) => comp = 3;
        }

        private void fullDraw()
        {
            if (view == 0) DrawTable();
            if (view == 1) DrawImageTable();
        }
        private void rgb_resize(object sender, EventArgs e)
        {
            int size = game.get_size();
            int xCellWidth = grb.Width / size;
            int xCellHeight = grb.Height / size;

            if (view == 0)
            {
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                    {
                        btn[i, j].Width = xCellWidth;
                        btn[i, j].Height = xCellHeight;
                        btn[i, j].Location = new Point((j * xCellWidth), (i * xCellHeight));
                    }
            }
            else
            {
                int count = 0;
                for(int i =0; i < size;i++)
                    for(int j =0; j < size;j++)
                    {
                        picbox[count].Width = xCellWidth;
                        picbox[count].Height = xCellHeight;
                        picbox[count++].Location = new Point((j * xCellWidth), (i * xCellHeight));
                    }
            }
        }
        private void DrawTable()
        {
            grb.Controls.Clear();
            int size = game.get_size();
            btn = new Button[size, size];
            int xCellWidth = grb.Width / size;
            int xCellHeight = grb.Height / size;
            int count = 0;
            int[,] pole = game.get_pole();
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Width = xCellWidth;
                    btn[i, j].Height = xCellHeight;
                    btn[i, j].Location = new Point((j * xCellWidth), (i * xCellHeight));
                    btn[i, j].Tag = count++.ToString();
                    btn[i, j].Text = pole[i, j].ToString();
                    if (pole[i, j] == 0) btn[i, j].Visible = false;
                    btn[i, j].Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular,
                    GraphicsUnit.Point, ((byte)(204)));
                    btn[i, j].Click += button_Click;
                    btn[i, j].KeyDown += Fm_KeyDown;
                    grb.Controls.Add(btn[i, j]);
                }   

        }

        private void DrawImageTable()
        {
            grb.Controls.Clear();
            int size = game.get_size();
            picbox = new List<PictureBox>();
            int xCellWidth = grb.Width / size;
            int xCellHeight = grb.Height / size;
            int count = 0;
            int[,] pole = game.get_pole();
            var imgarray = get_image(image_name);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    PictureBox pBox = new PictureBox();
                    pBox.Width = xCellWidth;
                    pBox.Height = xCellHeight;
                    pBox.Location = new Point((j * xCellWidth), (i * xCellHeight));
                    pBox.Tag = count++.ToString();
                    pBox.BorderStyle = BorderStyle.FixedSingle;

                    if (pole[i, j] == 0) pBox.Visible = false;

                    pBox.BackgroundImage = imgarray[pole[i, j]];
                    pBox.BackgroundImageLayout = ImageLayout.Stretch;
                    pBox.Click += PictureBoxClick;
                    picbox.Add(pBox);
                    grb.Controls.Add(pBox);
                }

        }
        private Image[] get_image(string image_name)
        {
            int size = game.get_size();
            var imgarray = new Image[size*size + 1];
            var img = (Image)Properties.Resources.ResourceManager.GetObject(image_name);
            var imgHeight = img.Height;
            var imgWidth = img.Width;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    
                    var index = i * size + j + 1;
                    imgarray[index] = new Bitmap(imgWidth/size, imgHeight/size);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, imgWidth / size, imgHeight / size), new Rectangle(j * (imgWidth / size), i * (imgHeight / size), imgWidth / size, imgHeight / size), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            return imgarray;
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                int x, y;
                int space_x, space_y;
                int size = game.get_size();
                int pos = int.Parse(pb.Tag.ToString());

                game.position_to_coords(pos, out x, out y);
                game.get_space_coord(out space_x, out space_y);
                int tag = game.coords_to_position(space_x,space_y);
                game.Moved(pos);

                if (space_x == x)
                {
                    int move = Math.Abs(tag - int.Parse(pb.Tag.ToString())); 
                    if (space_y > y)
                    {
                        for (int i = tag; i != tag - move; i--)
                        {
                           picbox[i].BackgroundImage = picbox[i-1].BackgroundImage;
                           picbox[i].Visible = true;
                           picbox[i - 1].Visible = false;
                        }
                    }

                    else if (space_y < y)
                    {
                        for (int i = tag; i != tag + move; i++)
                        {
                           picbox[i].BackgroundImage = picbox[i + 1].BackgroundImage;
                           picbox[i].Visible = true;
                           picbox[i + 1].Visible = false;  
                        }
                    }
                }

                else if (space_y == y)
                {
                    int move = Math.Abs(tag - int.Parse(pb.Tag.ToString())) / size;
                    if (space_x > x)
                    {
                        for (int i = tag; i > pos; i = i-size)
                        {

                            picbox[i].BackgroundImage = picbox[i - size].BackgroundImage;
                            picbox[i].Visible = true;
                            picbox[i - size].Visible = false;

                        }
                    }

                    else if (space_x < x)
                    {
                        for (int i = tag; i < pos; i = i + size)
                        {
                           picbox[i].BackgroundImage = picbox[i + size].BackgroundImage;
                           picbox[i].Visible = true;
                           picbox[i + size].Visible = false;  
                        }
                    }
                }
            }

            if (game.check_win())
                MessageBox.Show("Вы победили!\nМои поздравления.");
        }

        private void Fm_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is Button bu)
            {
                int x, y;
                int tag = int.Parse(bu.Tag.ToString());
                game.position_to_coords(tag, out x, out y);
                
                
                    if (e.Control)
                    {
                        switch (e.KeyCode)
                        {
                            case Keys.Left:
                                if(y != 0) btn[x, y - 1].Focus();
                                break;

                            case Keys.Up:
                                if(x != 0) btn[x - 1, y].Focus();
                                break;

                            case Keys.Down:
                                if(x != size -1) btn[x + 1, y].Focus();
                                break;

                            case Keys.Right:
                                if (y != size - 1) btn[x, y + 1].Focus();
                                break;

                            case Keys.Space:
                                button_Click(bu, e);
                                if (y != 0) btn[x, y - 1].Focus();
                                else if (x != 0) btn[x - 1, y].Focus();
                                else if (x != size - 1) btn[x + 1, y].Focus();
                                else if (y != size - 1) btn[x, y + 1].Focus();
                            break;
                        }
                    }
                
            }
            
        }

        private void tlpHardEvent(object sender, EventArgs e)
        {
            size = 5;
            game = new Game(size,view);
            game.start();
            if (view == 0) DrawTable();
            if (view == 1) DrawImageTable();
        }

        private void tlpMidEvent(object sender, EventArgs e)
        {
            size = 4;
            game = new Game(size,view);
            game.start();
            if (view == 0) DrawTable();
            if (view == 1) DrawImageTable();
        }

        private void tlpEasyEvent(object sender, EventArgs e)
        {
            size = 3;
            game = new Game(size,view);
            game.start();
            if (view == 0) DrawTable();
            if (view == 1) DrawImageTable();
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            if (sender is Button bu)
            {
                int x, y;
                int space_x, space_y;
                int size = game.get_size();
                int pos = int.Parse(bu.Tag.ToString());

                game.position_to_coords(pos, out x, out y);
                game.get_space_coord(out space_x, out space_y);
                game.Moved(pos);
                
                if(space_x == x)
                {
                    if (space_y > y)
                    {
                        for (int i = space_y; i > y; i--)
                        {           
                                btn[x, i].Text = btn[x, i - 1].Text;
                                btn[x, i].Visible = true;
                                bu.Visible = false;
                        }
                    }

                    else if(space_y < y)
                    {
                        for (int i = space_y; i < y; i++)
                        {
                                btn[x, i].Text = btn[x, i + 1].Text;
                                btn[x, i].Visible = true;
                                bu.Visible = false;
                        }
                    }
                }

                else if(space_y == y)
                {
                    if (space_x > x)
                    {
                        for (int i = space_x; i > x; i--)
                        {
                                btn[i, y].Text = btn[i - 1, y].Text;
                                btn[i, y].Visible = true;
                                bu.Visible = false;
                        }
                    }

                    else if (space_x < x)
                    {
                        for (int i = space_x; i < x; i++)
                        {
                                btn[i, y].Text = btn[i + 1, y].Text;
                                btn[i, y].Visible = true;
                                bu.Visible = false; 
                        }
                    }
                }
            }

            if (game.check_win())
                MessageBox.Show("Вы победили!\nМои поздравления.");
        }

        private void start_game(object sender, EventArgs e)
        {
            size = game.get_size();
            game = new Game(size, view);
            game.start();
            game.mix(comp);
            if (view == 0) DrawTable();
            if (view == 1) DrawImageTable();
        }

        private void game_number(object sender, EventArgs e)
        {
            view = 0;
            size = game.get_size();
            game = new Game(size, view);
            game.start();
            DrawTable();
        }

        private void game_image(object sender, EventArgs e)
        {
            view = 1;
            size = game.get_size();
            game = new Game(size, view);
            game.start();
            DrawImageTable();
        }

    }
}
