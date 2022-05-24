using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\tempStream.txt";


            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("1111111111");
                streamWriter.WriteLine("22222222");
                streamWriter.WriteLine("33333333");
                Console.WriteLine("Файл создан");
            } 
            
            using (StreamWriter streamWriter = new StreamWriter(path,true))
            {
                streamWriter.WriteLine("44");
                Console.WriteLine("Файл дописан");
            }

            using (StreamReader streamReader = new StreamReader(path))
            {

                Console.WriteLine("---начало---");
                Console.WriteLine(streamReader.ReadToEnd());
                Console.WriteLine("---конец---");
            }
            
            using (StreamReader streamReader = new StreamReader(path))
            {
                string line;
                int n = 1;
                while((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine($"Строка {n++} = [{line}]");
                }
                
                Console.WriteLine("Файл считан построчно");
                
            }
            var a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                foreach (var item in a)
                {
                    streamWriter.Write(item);
                }
                Console.WriteLine("Файл дописан");
            }

            using (StreamReader streamReader = new StreamReader(path))
            {   
                    Console.WriteLine(streamReader.ReadLineAsync().ToString());    
            }

        }
        
    }
}
