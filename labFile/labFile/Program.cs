using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\tmp.txt";
            var list = new List<string>()
            {
                "Один",
                "Два",
                "Три"
            };
            var xWriteText = string.Join(Environment.NewLine, list);
            File.WriteAllText(path, xWriteText);

            var xReadText = File.ReadAllText(path);
            Console.WriteLine(xReadText);

            Console.WriteLine(File.Exists(path));
            //
            File.Delete(path);
            FileInfo file = new FileInfo(path);
            Console.WriteLine(file.Exists);

            /*
             рассмотреть остальные методы File
             */
        }
    }
}
