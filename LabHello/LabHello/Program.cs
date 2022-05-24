using System;

namespace LabHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию:");
            string last_name = Console.ReadLine();
            Console.WriteLine("\nПривет, {0} {1}",name,last_name);
            Console.WriteLine("\nПока, {0} {1}", name, last_name);
            Console.WriteLine("\nЯ пошутил,не уходи, {0} {1}", name, last_name);
        }
    }
}
