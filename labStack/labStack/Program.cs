using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack x = new Stack();
            x.Push("Рязань");
            x.Push(123);
            x.Push("Тула");
            //
            Console.WriteLine(x.Peek());
            Console.WriteLine(x.Pop());
            Console.WriteLine(x.Pop());
            Console.WriteLine(x.Pop());

            #region try-catch-pop
            try
            {
                Console.WriteLine(x.Pop());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            #endregion
        }
    }
}
