using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(rand.Next(0, 1000) % 3);
            }
        }
    }
}
