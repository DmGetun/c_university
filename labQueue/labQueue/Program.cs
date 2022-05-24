using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue x = new Queue();
            //Queue<int> x = new Queue<int>();
            x.Enqueue(6);
            x.Enqueue(4);
            x.Enqueue(1);
            x.Enqueue("Hello");
            x.Enqueue(5);
            Console.WriteLine(x.Peek());
            Console.WriteLine("------");
            //
            while (x.Count > 0)
            {
                Console.WriteLine(x.Dequeue());
            }
        }
    }
}
