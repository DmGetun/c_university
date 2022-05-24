using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectSudoku
{
    class Game
    {
        /*
         Легкая = 30-35 чисел
         Средняя = 25-30 чисел
         Сложная = 20-25 чисел
         */
        int size = 9;
        public int[,] field;
        public int[,] grid = new int[,] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                                   { 4, 5, 6, 7, 8, 9, 1, 2, 3},
                                   { 7, 8, 9, 1, 2, 3, 4, 5, 6},
                                   { 2, 3, 4, 5, 6, 7, 8, 9, 1},
                                   { 5, 6, 7, 8, 9, 1, 2, 3, 4},
                                   { 8, 9, 1, 2, 3, 4, 5, 6, 7},
                                   { 3, 4, 5, 6, 7, 8, 9, 1, 2},
                                   { 6, 7, 8, 9, 1, 2, 3, 4, 5},
                                   { 9, 1, 2, 3, 4, 5, 6, 7, 8} };

        //int comp = 1;
        public int[,] rezField;
        private int count;
        public int WrongCount;
        

        Random rnd = new Random();

        Stack<int[]> lastMove = new Stack<int[]>();

        public int Comp {
            set 
            {
                if (value == 1) count = 81 - 35;
                if (value == 2) count = 81 - 30;
                if (value == 3) count = 81 - 25;
            } 
        }

        public Game()
        {
            field = new int[size, size];
            rezField = new int[size, size];
            this.WrongCount = 0;
            this.Comp = 1;
        }

        public void Start()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    field[i, j] = grid[i, j];
                }
            Mix();
        }

        public void Restart()
        {
            this.WrongCount = 0;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    field[i, j] = grid[i, j];
                }
            Mix();
        }
        public bool AddNumber(string number, int i, int j)
        {
            if (field[i,j] != 0 )
            {
                lastMove.Push(new int[3] { field[i, j], i, j });
            }
            field[i, j] = int.Parse(number);
            lastMove.Push(new int[3] { int.Parse(number),i,j});

            if (CheckNumber(field[i, j], i, j)) return true;
            else
            {
                WrongCount += 1;
                return false;
            }
        }
        private void Mix()
        {
             Transporate();
            
            for (int i = 0; i < 5; i++)
                SwapRowsSmall();
     
            for (int i = 0; i < 5; i++)
                SwapColumnsSmall();
            
            for (int i = 0; i < 5; i++)
                SwapRowsArea();

            for (int i = 0; i < 5; i++)
                SwapColumnsArea();

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    rezField[i, j] = field[i, j];
                }
            HideNumbers();
        }
        private void Transporate()
        {
            int t;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < i; j++)
                {
                    t = field[i, j];
                    field[i, j] = field[j, i];
                    field[j, i] = t;
                }
        }
        // обмен двух строк в пределах одного района
        private void SwapRowsSmall()
        {
            
            int area = rnd.Next(0, 3);
            
            int row1 = rnd.Next(0, 3);
            int row2 = rnd.Next(0, 3);

            while (row1 == row2) row2 = rnd.Next(0, 3);
            int temp;

            for (int j = 0; j < size; j++)
            {
                temp = field[3 * area + row1, j];
                field[3 * area + row1, j] = field[3 * area + row2, j];
                field[3 * area + row2, j] = temp;
            }
        }
        // обмен двух столбцов в пределах одного района
        private void SwapColumnsSmall()
        {
            int area = rnd.Next(0, 3);

            int col1 = rnd.Next(0, 3);
            int col2 = rnd.Next(0, 3);
            while(col1 == col2) col2 = rnd.Next(0, 3); 
            int temp;

            for (int j = 0; j < size; j++)
            {
                temp = field[j, 3 * area + col1];
                field[j, 3 * area + col1] = field[j, 3 * area + col2];
                field[j, 3 * area + col2] = temp;
            }
        }
        // обмен двух районов по горизонтали
        private void SwapRowsArea()
        {
            int area1 = rnd.Next(0, 3);

            int area2 = rnd.Next(0, 3);
            while(area1 == area2) area2 = rnd.Next(0, 3);
            int temp;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    temp = field[3 * area1 + i, j];
                    field[3 * area1 + i, j] = field[3 * area2 + i, j];
                    field[3 * area2 + i, j] = temp;
                }
            }
        }
        // обмен двух районов по вертикали
        private void SwapColumnsArea()
        {
            int area1 = rnd.Next(0, 3);

            int area2 = rnd.Next(0, 3);
            while(area1 == area2) area2 = rnd.Next(0, 3);
            int temp;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    temp = field[j, 3 * area1 + i];
                    field[j, 3 * area1 + i] = field[j, 3 * area2 + i];
                    field[j, 3 * area2 + i] = temp;
                }
            }
        }
        public int[,] GetField() => field;
        public int[,] GetRezField() => rezField;
        public void DeleteNumber(int i, int j)
        {
            field[i, j] = 0;
        }
        public bool CheckNumber(int number, int curRow, int curCol)
        {
            bool flag = true;
            int curAreaRow = curRow / 3;
            int curAreaCol = curCol / 3;

            for(int i = 0;i < size;i++)
            {
                if (i == curCol) continue;
                if (number == rezField[curRow, i]) flag = false;
            }
            for (int i = 0; i < size; i++)
            {
                if (i == curRow) continue;
                if (number == rezField[i, curCol]) flag = false;
            }

            curAreaRow *= 3;
            curAreaCol *= 3;

            for(int i = curAreaRow;i < curAreaRow + 3;i++)
                for (int j = curAreaCol; j < curAreaCol + 3; j++)
                {
                    if (i == curRow || i == curCol) continue;
                    if (number == rezField[i, j]) flag = false;
                }
            return flag;
        }
        public void HideNumbers()
        {
            while (count > 0)
            {
                int i = rnd.Next(0, 9);
                int j = rnd.Next(0, 9);

                if (field[i, j] != 0)
                {
                    field[i, j] = 0;
                    count--;
                }
            }
        }
        public bool CheckWin()
        {
            for(int i = 0;i < size;i++)
                for (int j = 0; j < size; j++)
                {
                    if (field[i, j] != rezField[i, j]) return false;
                }
            return true;
        }
        public void CancelMove()
        {
            if (lastMove.Count > 0)
            {
                var mass = lastMove.Pop();
                DeleteNumber(mass[1], mass[2]);
                if (lastMove.Count == 0) return;

                mass = lastMove.Pop();
                AddNumber(mass[0].ToString(), mass[1], mass[2]);
                lastMove.Pop();
            }
        }

        public bool CheckLose()
        {
            if (WrongCount == 3) return true;
            return false;
        }
    }
}

