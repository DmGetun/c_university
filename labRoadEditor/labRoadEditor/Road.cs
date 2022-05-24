using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labRoadEditor
{
    class Road
    {
        int Rows, Cols;
        string[,] mapRoad;
        public Road(int Rows,int Cols)
        {
            this.Rows = Rows;
            this.Cols = Cols;
            mapRoad = new string[Rows,Cols];
        }

        public void StartDraw()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    mapRoad[i, j] = "n";
                }    
            }
        }

        public void GetCoords(string tag, out int i, out int j)
        {
            int Tag;
            if (tag == "a") Tag = 10; 
            else if (tag == "b") Tag = 11; 
            else if (tag == "c") Tag = 12;
            else 
                Tag = int.Parse(tag);

            Tag -= 1;
            i = Tag / 4;
            j = Tag % 4;
        }

        public void  AddToRoad(string tag,int i, int j)
        {
            mapRoad[i,j] = tag;
        }

        public void SaveRoad()
        {
            string path = null;
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.SelectedPath + $"\\Road{Rows}_{Cols}.txt";
                else return;

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        streamWriter.Write(mapRoad[i,j]);
                    }
                    streamWriter.Write(streamWriter.NewLine);
                }
            }
        }

        public string DownloadRoad()
        {
            string path = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                path = ofd.FileName;
            }
            else return "";

            var lines = 0;
            var columns = 0;
            using (StreamReader streamReader = new StreamReader(path))
            {
                try
                {
                    for (int i = 0; i < Rows; i++)
                    {
                        var line = streamReader.ReadLine();
                        lines++;
                        columns = 0;
                        for (int j = 0; j < Cols; j++)
                        {
                            mapRoad[i, j] = line[j].ToString();
                            columns++;
                        }
                        if (columns != Cols)
                        {
                            StartDraw();
                            return "Несоответствие размеров";
                        }
                    }
                    if (lines != Rows)
                    {
                        StartDraw();
                        return "Несоответствие размеров";
                    }
                }
                catch
                {
                    StartDraw();
                    return "Несоответствие размеров";
                }
            }
            return "";
        }

        public void DeleteFromRoad(int row, int col)
        {
            mapRoad[row, col] = "n";
        }

        public string[,] ReturnRoad()
        {
            return mapRoad;
        }
    }
}
