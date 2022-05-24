using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            // (1)
            var t1 = new Task(myTask1);
            t1.Start();
            t1.Wait();
            //t1.Status == TaskStatus.

            // (2)
            new Task(() => Console.WriteLine("Task2")).Start();

            // (3)
            Task.Run(() => Console.WriteLine("Task3"));

            // (4)
            Task.Run(async () => { await Task.Delay(100); Console.WriteLine("Task4"); } );

            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void myTask1()
        {
            Console.WriteLine("Task1");
        }
    }
}
