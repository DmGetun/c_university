using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var x0 = 5;
            int x00 = 5;

            //(1)
            var x1 = (2, 4);
            Console.WriteLine(x1.Item1);
            Console.WriteLine(x1.Item2);

            //(2) название полей кортежа
            (int min, int max) x2 = (2, 4);
            Console.WriteLine(x2.min);
            Console.WriteLine(x2.max);
            Console.WriteLine();

            //(3)   название полей кортежа через инициализацию
            var x3 = (min: 2, max: 4);
            Console.WriteLine(x3.min);
            Console.WriteLine(x3.max);
            Console.WriteLine();

            //(4) Отдельные переменные для каждого поля
            var (min, max) = (2, 4);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine();

            //(5) получение кортежа из функции
            var x5 = GetX5();
            Console.WriteLine(x5.Item1);
            Console.WriteLine(x5.Item2);
            Console.WriteLine();

            //(6) получение кортежа из функции c именами
            var x6 = GetX6();
            Console.WriteLine(x6.min);
            Console.WriteLine(x6.max);
            Console.WriteLine();

            //(7) кортеж в качестве параметра
            var x7 = GetX7((4,5),6);
        }

        private static (int, int) GetX7((int, int) p, int v) => (p.Item1 + p.Item2, v);

        //private static (int,int) GetX7((int, int) p, int v)
        //{
        //    return (p.Item1 + p.Item2,v);
        //}

        private static (int min,int max) GetX6()
        {
            return (3, 6);
        }

        private static (int,int) GetX5()
        {
            return (3, 6);
        }
    }
}
