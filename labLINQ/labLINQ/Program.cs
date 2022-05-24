using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //---- ПРИМЕР 1 -----
            //var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var arr = Enumerable.Range(0, 10).ToArray();
            var myQuery =
                from v in arr
                where v > 5 && v < 8
                orderby v descending
                select v;
            Console.WriteLine(string.Join(" ",arr));
            Console.WriteLine(string.Join(" ",myQuery));
            Console.WriteLine($"Count = {myQuery.Count()},Sum = {myQuery.Sum()}");
            Console.WriteLine("--------------------------------");
            //---- ПРИМЕР 2 -----
            var arr2 = new string[] { "Юра", "Миша", "Сергей", "Игорь", "Дима", "Антон", "гриша","майкл","Максим" };
            var myQuery2 =
                from v in arr2
                where v.ToUpper().StartsWith("М")
                orderby v
                select $"<{v}>";

            Console.WriteLine(string.Join(" ", arr2));
            Console.WriteLine(string.Join(" ", myQuery2));
        }
    }
}
