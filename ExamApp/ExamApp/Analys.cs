using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    class Analys
    {
        public Dictionary<string, Dictionary<string, string>> dict = new Dictionary<string, Dictionary<string, string>>();

        private SQLiteConnection db;

        public List<string> indexDirs;

        public List<string> AnalysQ = new List<string>();

        Dictionary<string, long> indexFiles;

        public Analys()
        {
            db = new SQLiteConnection("myDB.db");
            db.CreateTable<Dirs>();
            GetDrivers();
            indexDirs = new List<string>();
            indexFiles = new Dictionary<string, long>();
        }
        public void StartAnalys()
        {
            List<string> dirs = AnalysQ;
            foreach (string dir in dirs)
            {
                if (!Directory.Exists(dir))
                    dirs.Remove(dir);
            }
            Parallel.ForEach(dirs, Analyses);
        }

        public long GetSize(string item)
        {
            var query = db.Query<Dirs>("Select Size from Dirs where Name = ?", item);
            long i = 0;
            if (query.Count > 1)
            {
                i = query[0].Size;
                return i;
            }
            return i;
        }
        public void Analyses(string dir)
        {
            string folderSize = "";
            Dirs dir1 = new Dirs();
            DirectoryInfo info = new DirectoryInfo(dir);
            long size_ = SizeOfDirectory(dir);
            float size = NewSizeDir(size_, out folderSize);
            var file = new FileInfo(info.FullName);
            Dictionary<string, string> temp = new Dictionary<string, string>();
            dir1.Name = info.FullName;
            temp["name"] = info.Name;
            temp["size"] = $"{size} {folderSize}";
            dir1.Size = size_;

            temp["fileCount"] = info.GetFiles().Length.ToString();
            dir1.FileCount = info.GetFiles().Length;

            temp["dirCount"] = info.GetDirectories().Length.ToString();
            dir1.DirCount =  info.GetDirectories().Length;

            temp["lastMod"] = file.LastWriteTime.ToString();
            dir1.LastMod = file.LastWriteTime;

            double percent = PercentPar(dir, size_);
            temp["percentParent"] = $"{percent} %";
            dir1.PercentPar = percent;
            
            temp["type"] = "Folder";
            if (indexDirs.IndexOf(dir) == -1)
            {
                db.Update(dir1);
            }
            else
            {
                db.Insert(dir1);
            }
            if(indexDirs.IndexOf(temp["name"]) != -1)
                indexDirs.Add(temp["name"]);
            

            AnalysQ.Remove(dir);

            dict[dir] = temp;
        }

        private double PercentPar(string dir, long curSize)
        {
            string folderSize = "";
            DirectoryInfo info = new DirectoryInfo(dir);
            var parent = info.Parent;
            long size_ = SizeOfDirectory(parent.FullName);

            return Math.Round(((double)curSize / size_ * 100),2);
        }
        public long SizeOfDirectory(string dir)
        {
            long i = 0;
            var query = db.Query<Dirs>("Select Size from Dirs where Name = ?", dir);
            if(query.Count > 1)
            {
                i = query[0].Size;
                return i;
            }
            
            try
            {
                DirectoryInfo DrInfo = new DirectoryInfo(dir);
                DirectoryInfo[] folder = DrInfo.GetDirectories();
                FileInfo[] Fi = DrInfo.GetFiles();

                foreach (FileInfo fl in Fi)
                {
                    i += fl.Length;
                }

                for (int j = 0; j < folder.Length; j++)
                {
                    i += SizeOfDirectory(Path.Combine(dir, folder[j].Name));
                }
                return i;
            }
            catch
            {
                return 0;
            }
        }

        public float NewSizeDir(long length, out string folderSize)
        {
            float sizeB = 0;
            folderSize = "байт";
            if (length / 1024 >= 1)
            {
                folderSize = "Кбайт";
                sizeB = (float)(length / 1024);
            }

            if (length / 1024 / 1024 >= 1)
            {
                folderSize = "Мбайт";
                sizeB = (float)(length / 1024 / 1024);
            }

            if (length / 1024 / 1024 / 1024 > 0)
            {
                folderSize = "Гбайт";
                sizeB = (float)(length / 1024 / 1024 / 1024);
            }
            return sizeB;
        }

        public double PercentDrive(long totalSpace, long freeSize)
        { 
            var size = totalSpace - freeSize;
            return Math.Round((double)size / totalSpace * 100, 2);
        }

        private void GetDrivers()
        {
            foreach (var driver in DriveInfo.GetDrives())
            {
                db.Execute("Insert into Dirs(Name,Size) values (?,?)", driver.Name, driver.TotalSize);
            }
        }
    }

    internal class Dirs
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public int FileCount { get; set; }
        public int DirCount { get; set; }
        public DateTime LastMod { get; set; }
        public double PercentPar { get; set; }
    }
}
