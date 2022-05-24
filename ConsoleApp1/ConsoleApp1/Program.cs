using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string var1 = "123";
            string var2 = "123";

            if(var1 == var2)
                Console.WriteLine("True");
            if(var1.Equals(var2))
                Console.WriteLine("True");
        }
    }
}
