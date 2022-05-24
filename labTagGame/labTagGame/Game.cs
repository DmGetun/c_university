using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTagGame
{
    class Game
    {
        public int[,] matr;
        int size;
        int space_x, space_y;
        int view; // 0 - цифры, 1 - картинки

        public Game(int size,int view)
        {
            this.size = size;
            this.view = view;
            matr = new int[size, size];
            space_x = size - 1;
            space_y = size - 1;          
        }

        public int get_size()
        {
            return this.size;
        }

        public void start()
        {
            space_x = size - 1;
            space_y = size - 1;
            int count = 1;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matr[i,j] = count++;
            matr[size - 1, size - 1] = 0;
        }

        public void mix(int comp)
        {
            int size = get_size();
            space_x = size-1;
            space_y = size-1;
            int x, y;
            int last_x = size - 1, last_y = size - 1;
            int complex = comp * comp * size * size;

            Random rnd = new Random();

            while(complex != 0)
            {
                // 0 - up, 1 - down, 2 - left, 3 - right
 
                get_space_coord(out x, out y);
                int pos;
                int dir = rnd.Next(0, 255) % 4;

                switch (dir)
                {
                    case 0:
                        if (x == 0) break;
                        if (x - 1 == last_x) break;
                        pos = coords_to_position(x - 1, y);
                        last_x = x;
                        last_y = y;
                        Moved(pos);
                        complex--;
                        break;
                    case 1:
                        if (x == size - 1) break;
                        if (x + 1 == last_x) break;
                        pos = coords_to_position(x + 1, y);
                        last_x = x;
                        last_y = y;
                        Moved(pos);
                        complex--;
                        break;
                    case 2:
                        if (y == 0) break;
                        if (y - 1 == last_y) break;
                        pos = coords_to_position(x, y - 1);
                        last_x = x;
                        last_y = y;
                        Moved(pos);
                        complex--;
                        break;
                    case 3:
                        if (y == size - 1) break;
                        if (y + 1 == last_y) break;
                        pos = coords_to_position(x, y + 1);
                        last_x = x;
                        last_y = y;
                        Moved(pos);
                        complex--;
                        break;
                }
            }     
        }

        public int[,] get_pole()
        {
            return matr;
        }

        public bool check_win()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (!(i == size - 1 && j == size - 1))
                        if (matr[i, j] != (coords_to_position(i, j) + 1))
                            return false;
                }
            return true;
        }
        public int get_number(int position)
        {
            int x, y;
            position_to_coords(position, out x, out y);
            if (x < 0 || x >= size)
                return 0;
            if (y < 0 || y >= size)
                return 0;
            return matr[x, y];
        }

        public int coords_to_position(int x, int y)
        {
            return x * size + y;
        }

        public void position_to_coords(int position, out int x, out int y)
        {
            x = position / size;
            y = position % size;
        }

        public void Moved(int position)
        {
            int x, y;
            position_to_coords(position, out x, out y);
            
            if (space_x == x)
            {
                if (space_y > y)
                {
                    for (int i = space_y; i > y; i--)
                    {
                        matr[x, i] = matr[x, i - 1];
                        matr[x, i - 1] = 0;
                        space_x = x;
                        space_y = y;
                    }
                }

                else if (space_y < y)
                {
                    for (int i = space_y; i < y; i++)
                    {
                        matr[x, i] = matr[x, i + 1];
                        matr[x, i + 1] = 0;
                        space_x = x;
                        space_y = y; 
                    }
                }
            }

            else if (space_y == y)
            {
                if (space_x > x)
                {
                    for (int i = space_x; i > x; i--)
                    {
                        matr[i, y] = matr[i - 1, y];
                        matr[i -1 , y] = 0;
                        space_x = x;
                        space_y = y;
                    }
                }

                else if (space_x < x)
                {
                    for (int i = space_x; i < x; i++)
                    {
                        matr[i, y] = matr[i + 1, y];
                        matr[i + 1, y] = 0;  
                        space_x = x;
                        space_y = y;
                    }
                }
            }
        }
        public void get_space_coord(out int x, out int y)
        {
            x = space_x;
            y = space_y;
        }
    }
}
