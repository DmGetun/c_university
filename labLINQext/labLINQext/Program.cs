using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labLINQext
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[] {"Москва", "Сочи", "Орёл", "Самара", "Смоленск", "Ялта", "Сумы", };

            //var x1 = arr.Where(v => v.StartsWith("С") && v.Length > 5).OrderBy(v =>v ).ToArray();

            var x1 = arr.Where(v => v.StartsWith("С")).Where(v=>v.Length > 5).OrderBy(v =>v ).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,x1));
            Console.WriteLine();

            var x2 = arr.OrderBy(v=>v).Select(v => $"{v} - {v.Contains('а')}").ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,x2));
        }
    }
}
